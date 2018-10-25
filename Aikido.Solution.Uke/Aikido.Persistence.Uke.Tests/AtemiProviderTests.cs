using NUnit.Framework;
using Aikido.Persistence.Uke;
using Aikido.Domain.Uke.Entities;

namespace Aikido.Persistence.Uke.Tests
{
    [TestFixture]
    public class Tests
    {
        private AtemiProvider _atemiProvider;

        [SetUp]
        public void AtemiProvider()
        {
            _atemiProvider = new AtemiProvider();
        }

        [Test]
        public void GetShouldReturnARandomAtemi()
        {
            var atemi = _atemiProvider.Get();
            
            Assert.That(atemi, Is.TypeOf(typeof(Atemi)));
            Assert.That(atemi.Name, Is.Not.Null.Or.Empty);
            Assert.Pass();
        }
    }
}