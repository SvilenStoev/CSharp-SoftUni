// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using FestivalManager.Entities;
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class StageTests
    {

        private Performer performer;
        private Song song;
        private Stage stage;

        [SetUp]
        public void setUp()
        {
            this.song = new Song("Ветрове", new TimeSpan(0, 0, 30));
            this.stage = new Stage();
        }

        [Test]
        public void AddSongTest()
        {
            this.song = new Song("Ветрове", new TimeSpan(0, 0, 30));

            Assert.That(
                () => this.stage.AddSong(this.song),
                Throws.ArgumentException);
        }

        [Test]
        public void AddSongTestException()
        {
            this.song = null;

            Assert.That(
                () => this.stage.AddSong(this.song),
                Throws.ArgumentNullException);
        }

        [Test]
        public void AddPerformerTestException()
        {
            Performer performer = null;

            Assert.That(
                () => this.stage.AddPerformer(performer),
                Throws.ArgumentNullException);
        }

        [Test]
        public void AddPerformerTestExceptionAge()
        {
            var performer = new Performer("Ivan", "Ivanov", 17);

            Assert.That(
                () => this.stage.AddPerformer(performer),
                Throws.ArgumentException);
        }

        [Test]
        public void AddPerformerTest()
        {
            var performer = new Performer("Ivan", "Ivanov", 19);

            this.stage.AddPerformer(performer);

            Assert.That(this.stage.Performers.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddSongToPerformerTestException()
        {
            Assert.That(
                () => this.stage.AddSongToPerformer(null, "Peshoo"),
                Throws.ArgumentNullException);

            Assert.That(
                () => this.stage.AddSongToPerformer("ValidName", null),
                Throws.ArgumentNullException);
        }

        [Test]
        public void AddSongToPerformerTest()
        {
            var song1 = new Song("Ветрове", new TimeSpan(0, 3, 30));
            var song2 = new Song("Бурни Нощи", new TimeSpan(0, 2, 30));

            var performer = new Performer("Ivan", "Ivanov", 19);

            this.stage.AddSong(song1);
            this.stage.AddSong(song2);
            this.stage.AddPerformer(performer);

            string expected = $"{song1.ToString()} will be performed by {performer.FullName}";
            string actual = this.stage.AddSongToPerformer(song1.Name, performer.FullName);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayTest()
        {
            var song1 = new Song("Ветрове", new TimeSpan(0, 3, 30));
            var song2 = new Song("Бурни Нощи", new TimeSpan(0, 2, 30));

            var performer = new Performer("Ivan", "Ivanov", 19);

            this.stage.AddSong(song1);
            this.stage.AddSong(song2);
            this.stage.AddPerformer(performer);

            var songsCount = this.stage.Performers.Sum(p => p.SongList.Count());

            string expected = $"{this.stage.Performers.Count} performers played {songsCount} songs";
            string actual = this.stage.Play();

            Assert.AreEqual(expected, actual);
        }

    }
}