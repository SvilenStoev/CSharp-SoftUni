namespace VaporStore.DataProcessor
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;

    public static class Serializer
    {
        public static string ExportGamesByGenres(VaporStoreDbContext context, string[] genreNames)
        {
            var games = context
                .Genres
                .ToList()
                .Where(x => genreNames.Contains(x.Name))
                .Select(x => new
                {
                    Id = x.Id,
                    Genre = x.Name,
                    Games = x.Games.Select(g => new
                    {
                        Id = g.Id,
                        Title = g.Name,
                        Developer = g.Developer.Name,
                        Tags = string.Join(", ", g.GameTags.Select(gt => gt.Tag.Name)),
                        Players = g.Purchases.Count(),
                    }).Where(g => g.Players > 0).OrderByDescending(g => g.Players).ThenBy(g => g.Id),
                    TotalPlayers = x.Games.Sum(g => g.Purchases.Count()),
                })
                .OrderByDescending(x => x.TotalPlayers).ThenBy(x => x.Id);

            return JsonConvert.SerializeObject(games, Formatting.Indented);
        }

        public static string ExportUserPurchasesByType(VaporStoreDbContext context, string storeType)
        {
            return "";
        }
    }
}