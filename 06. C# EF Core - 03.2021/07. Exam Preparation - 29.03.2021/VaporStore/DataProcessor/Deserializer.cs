namespace VaporStore.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.DataProcessor.Dto.Import;

    public static class Deserializer
    {
        public static string ImportGames(VaporStoreDbContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var games = JsonConvert.DeserializeObject<IEnumerable<GameJsonImportModel>>(jsonString);

            foreach (var jsonGame in games)
            {
                if (!IsValid(jsonGame) || jsonGame.Tags.Count() == 0)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var genre = context.Genres.FirstOrDefault(x => x.Name == jsonGame.Genre) ?? new Genre { Name = jsonGame.Genre };
                var developer = context.Developers.FirstOrDefault(x => x.Name == jsonGame.Developer) ?? new Developer { Name = jsonGame.Developer };

                var game = new Game
                {
                    Name = jsonGame.Name,
                    Genre = genre,
                    Developer = developer,
                    Price = jsonGame.Price,
                    ReleaseDate = jsonGame.ReleaseDate.Value,
                };

                foreach (var jsonTag in jsonGame.Tags)
                {
                    var tag = context.Tags.FirstOrDefault(x => x.Name == jsonTag) ?? new Tag { Name = jsonTag };
                    game.GameTags.Add(new GameTag { Tag = tag });
                }

                context.Games.Add(game);
                context.SaveChanges();
                sb.AppendLine($"Added {jsonGame.Name} ({jsonGame.Genre}) with {jsonGame.Tags.Count()} tags");
            }

            return sb.ToString().TrimEnd();
        }

        public static string ImportUsers(VaporStoreDbContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var users = JsonConvert.DeserializeObject<IEnumerable<UsersJsonImportModel>>(jsonString);

            foreach (var jsonUser in users)
            {
                if (!IsValid(jsonUser) || !jsonUser.Cards.All(c => IsValid(c)))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var user = new User
                {
                    Age = jsonUser.Age,
                    Email = jsonUser.Email,
                    FullName = jsonUser.FullName,
                    Username = jsonUser.Username,
                    Cards = jsonUser.Cards.Select(x => new Card
                    {
                        Cvc = x.CVC,
                        Number = x.Number,
                        Type = x.Type.Value,
                    }).ToList()
                };

                context.Users.Add(user);
                context.SaveChanges();
                sb.AppendLine($"Imported {user.Username} with {user.Cards.Count()} cards");
            }

            return sb.ToString().TrimEnd();
        }

        public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var xmlSerializer = new XmlSerializer(typeof(PurchaseXmlInputModel[]),
                new XmlRootAttribute("Purchases")); //Това е най-отгоре от Xml файла!

            var purchases = (PurchaseXmlInputModel[])xmlSerializer.Deserialize(new StringReader(xmlString));

            foreach (var xmlPurchase in purchases)
            {
                if (!IsValid(xmlPurchase))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var parsedDate = DateTime.TryParseExact(xmlPurchase.Date, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date);

                if (!parsedDate)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var purchase = new Purchase
                {
                    Date = date,
                    Type = xmlPurchase.Type.Value,
                    ProductKey = xmlPurchase.Key,
                    Card = context.Cards.FirstOrDefault(c => c.Number == xmlPurchase.Card),
                    Game = context.Games.FirstOrDefault(g => g.Name == xmlPurchase.Title),
                };

                context.Purchases.Add(purchase);
                context.SaveChanges();

                var username = context.Users.Where(u => u.Id == purchase.Card.UserId).Select(x => x.Username).FirstOrDefault();
                sb.AppendLine($"Imported {xmlPurchase.Title} for {username}"!);
            }

            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}