using NUnit.Framework;
using Aikido.Domain.Uke.Entities;

namespace Aikido.Domain.Uke.Tests
{
    [TestFixture]
    public class AtemiTests
    {
        Atemi _atemi;

        [TestCase("tsuki")]
        [TestCase("shomen uchi")]
        [TestCase("yokomen uchi")]
        public void AtemiShouldReturnExpectedResult(string value)
        {
            _atemi = new Atemi(value);
            Assert.AreEqual(value, _atemi.Name);
            Assert.Pass();
        }
    }
}