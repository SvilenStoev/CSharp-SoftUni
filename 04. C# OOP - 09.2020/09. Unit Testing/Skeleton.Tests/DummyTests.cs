using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private const int Experience = 300;
    private Dummy aliveDummy;
    private Dummy deadDummy;

    [SetUp]
    public void SetUpDummy()
    {
        this.aliveDummy = new Dummy(200, Experience);
        this.deadDummy = new Dummy(0, Experience);
    }

    [Test]
    public void DummyShouldLosesHealthIfAttacked()
    {
        // Act
        this.aliveDummy.TakeAttack(50);

        // Assert
        Assert.That(this.aliveDummy.Health, Is.EqualTo(150));
    }

    [Test]
    public void DeadDummyShouldThrowsExceptionIfAttacked()
    {
        // Assert
        Assert.That(
            () => this.deadDummy.TakeAttack(200), // Act
            Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."), "Dead dummy can't be attack.");
    }

    [Test]
    public void DeadDummyShouldBeAbleToGiveXP()
    {
        //Act
        int givenExperience = this.deadDummy.GiveExperience;

        // Assert
        Assert.That(givenExperience, Is.EqualTo(Experience));
    }

    [Test]
    public void DummyShoulNotdBeAbleToGiveXPIfAlive()
    {
        // Assert
        Assert.That(
            () => this.aliveDummy.GiveExperience, // Act
            Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}
