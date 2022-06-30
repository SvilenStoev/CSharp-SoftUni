namespace MusicHub
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            //DbInitializer.ResetDatabase(context);

            //Test your solutions here

            Console.WriteLine(ExportSongsAboveDuration(context, 4));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var sb = new StringBuilder();

            var albums = context
                .Albums
                .Where(a => a.ProducerId == producerId)
                .Select(a => new
                {
                    AlbumName = a.Name,
                    AlbumReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy"),
                    AlbumPrice = a.Price,
                    Producer = a.Producer,
                    Songs = a.Songs
                        .Select(s => new
                        {
                            s.Name,
                            s.Price,
                            SongWriter = s.Writer,
                        }).ToList()
                }).ToList();

            foreach (var album in albums.OrderByDescending(a => a.AlbumPrice))
            {
                sb
                    .AppendLine($"-AlbumName: {album.AlbumName}")
                    .AppendLine($"-ReleaseDate: {album.AlbumReleaseDate}")
                    .AppendLine($"-ProducerName: {album.Producer.Name}")
                    .AppendLine($"-Songs:");

                int i = 1;

                foreach (var song in album.Songs.OrderByDescending(s => s.Name).ThenBy(s => s.SongWriter.Name))
                {
                    sb
                        .AppendLine($"---#{i++}")
                        .AppendLine($"---SongName: {song.Name}")
                        .AppendLine($"---Price: {song.Price:F2}")
                        .AppendLine($"---Writer: {song.SongWriter.Name}");
                }

                sb.AppendLine($"-AlbumPrice: {album.AlbumPrice:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            StringBuilder sb = new StringBuilder();

            TimeSpan ts = TimeSpan.FromTicks(duration);

            var songs = context
                .Songs
                .Where(s => s.Duration > ts)
                .Select(s => new
                {
                    SongName = s.Name,
                    PerformerFullName = s.SongsPerformers.First(sp => sp.SongId == s.Id).Performer.FirstName + " " + s.SongsPerformers.First(sp => sp.SongId == s.Id).Performer.LastName,
                    WriterName = s.Writer.Name,
                    AlbumProducer = s.Album.Producer.Name,
                    Duration = s.Duration,
                }).ToList();

            int i = 1;

            foreach (var song in songs.OrderBy(s => s.SongName).ThenBy(s => s.WriterName).ThenBy(s => s.PerformerFullName))
            {
                sb
                    .AppendLine($"-Song #{i++}")
                    .AppendLine($"---SongName: {song.SongName}")
                    .AppendLine($"---Writer: {song.WriterName}")
                    .AppendLine($"---Performer: {song.PerformerFullName}")
                    .AppendLine($"---AlbumProducer: {song.AlbumProducer}")
                    .AppendLine($"---Duration: {song.Duration:c}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
