using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DragonTests
    {
        [Test]
        public void DragonShouldBeAbleToIntroduceItSelf()
        {
            const string name = "Drago";

            // Arrange
            var introducer = new FakeIntroducer();
            var dragon = new Dragon(name, introducer);

            // Act
            dragon.Introduce();

            // Assert
            Assert.That(introducer.Message, Is.EqualTo($"I am {name} and I am blue and nice."));
        }

    }
}
