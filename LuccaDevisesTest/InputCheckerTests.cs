using LuccaDevises.Services;
using NUnit.Framework;

namespace LuccaDevisesTest
{
    public class InputCheckerTests
    {
        [Test]
        [TestCase(GoodEntries.GivenExempleFirstLine)]
        public void CheckFirstLineOk(string line)
        {
            Assert.IsTrue(InputChecker.CheckFirstLine(line));
        }

        [Test]
        public void CheckSecondLine()
        {
            Assert.IsTrue(InputChecker.CheckSecondLine(GoodEntries.GivenExempleSecondLine));
        }

        [Test]
        public void CheckOtherOk()
        {
            Assert.IsTrue(InputChecker.CheckOthers(GoodEntries.GivenExempleSecondLine, GoodEntries.GivenExempleOthersLine));
            Assert.IsTrue(InputChecker.CheckOthers("1", GoodEntries.GivenExempleOthersLine));
        }

        [Test]
        [TestCase(BadEntries.OtherLineKO1)]
        [TestCase(BadEntries.OtherLineKO2)]
        [TestCase(BadEntries.OtherLineKO3)]
        [TestCase(BadEntries.OtherLineKO4)]
        [TestCase(BadEntries.OtherLineKO5)]
        [TestCase(BadEntries.OtherLineKO6)]
        [TestCase(BadEntries.OtherLineKO7)]
        [TestCase(BadEntries.OtherLineKO8)]
        [TestCase(BadEntries.OtherLineKO9)]
        public void CheckOtherKo(string line)
        {
            Assert.IsFalse(InputChecker.CheckOther(line));
        }

        [Test]
        [TestCase(GoodEntries.CurrencyOk)]
        public void CheckDeviseOk(string currency)
        {
            Assert.IsTrue(InputChecker.CheckDevises(currency));
        }

        [Test]
        [TestCase(BadEntries.CurrencyKo1)]
        [TestCase(BadEntries.CurrencyKo2)]
        [TestCase(BadEntries.CurrencyKo3)]
        public void CheckDeviseKO(string currency)
        {
            Assert.IsFalse(InputChecker.CheckDevises(currency));
        }

        [Test]
        public void CheckIntegerOk()

        {
            Assert.IsTrue(InputChecker.CheckInteger("1"));
        }

        [Test]
        [TestCase(BadEntries.IntegerKo1)]
        [TestCase(BadEntries.IntegerKo2)]
        [TestCase(BadEntries.IntegerKo3)]
        [TestCase(BadEntries.IntegerKo4)]
        public void CheckIntegerKo(string integer)
        {
            Assert.IsFalse(InputChecker.CheckInteger(integer));
        }

        [Test]
        [TestCase(GoodEntries.RateOk1)]
        [TestCase(GoodEntries.RateOk2)]
        [TestCase(GoodEntries.RateOk3)]
        [TestCase(GoodEntries.RateOk4)]
        [TestCase(GoodEntries.RateOk5)]
        public void CheckRateOk(string rate)
        {
            Assert.IsTrue(InputChecker.CheckRate(rate));
        }

        [Test]
        [TestCase(BadEntries.RateKo1)]
        [TestCase(BadEntries.RateKo2)]
        public void CheckRateKo(string rate)
        {
            Assert.IsFalse(InputChecker.CheckRate(rate));
        }

        [Test]
        public void CheckOkFile()
        {
            Assert.IsTrue(InputChecker.CheckFile(GoodEntries.GivenExemple));
        }

        [Test]
        public void CheckNOkFiles()
        {
            Assert.IsFalse(InputChecker.CheckFile(BadEntries.EmptyLines));
            Assert.IsFalse(InputChecker.CheckFile(BadEntries.PartialLines));
        }

        [Test]
        public void CheckNOkCurrency()
        {
            Assert.IsFalse(InputChecker.CheckFile(BadEntries.Currency1));
            Assert.IsFalse(InputChecker.CheckFile(BadEntries.Currency2));
            Assert.IsFalse(InputChecker.CheckFile(BadEntries.Currency3));
            Assert.IsFalse(InputChecker.CheckFile(BadEntries.Currency4));
        }
    }
}