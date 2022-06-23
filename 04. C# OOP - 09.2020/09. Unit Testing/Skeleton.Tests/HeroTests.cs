using NUnit.Framework;
using Skeleton.Contracts;
using Skeleton.Fakes;

[TestFixture]
public class HeroTests
{
    [Test]
    public void HeroShouldGainingXPWhenTargetIsDead()
    {
        //Arrange
        ITarget target = new FakeTarget();
        IWeapon weapon = new FakeWeapon();
        var hero = new Hero("Gosho", weapon);

        //Act
        hero.Attack(target);

        //Assert
        Assert.That(hero.Experience, Is.EqualTo(FakeTarget.DEFAULT_EXPERIENCE));
    }
}