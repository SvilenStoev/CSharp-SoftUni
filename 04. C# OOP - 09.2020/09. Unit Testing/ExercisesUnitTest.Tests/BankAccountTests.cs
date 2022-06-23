using Exercises;
using NUnit.Framework;


namespace ExercisesUnitTest.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void CreatingBankAccountShouldSetInitialAmount()
        {
            var bankAccount = new BankAccount(5.5m);

            Assert.AreEqual(5.5m, bankAccount.Amount);
        }
    }
}