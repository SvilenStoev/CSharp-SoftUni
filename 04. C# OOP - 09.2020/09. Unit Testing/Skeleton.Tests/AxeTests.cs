using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private Dummy target;

    [SetUp]
    public void SetDummy()
    {
        this.target = new Dummy(100, 200);
    }

    [Test]
    public void AxeShouldLoseDurabilityAfterAttack()
    {
        // Arrange
        var axe = new Axe(10, 10);

        // Act
        axe.Attack(this.target);

        // Assert

        Assert.AreEqual(9, axe.DurabilityPoints);
    }

    [Test]
    public void AxeShouldThrowExceptionIfAnAttackIsMadeWithBrokenWeapon()
    {

        // Arrange
        var axe = new Axe(1, 0);

        // Assert
        Assert.That( //Act
            () => axe.Attack(this.target), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
    }
}