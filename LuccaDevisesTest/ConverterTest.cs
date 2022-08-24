using LuccaDevises.Services;
using NUnit.Framework;

namespace LuccaDevisesTest
{
    public class ConverterTest
    {

        [Test]
        public void CheckExemple()
        {
            Converter converter = new Converter();
            Assert.AreEqual(59033, converter.Convert(GoodEntries.GivenExemple));
        }
    }
}
