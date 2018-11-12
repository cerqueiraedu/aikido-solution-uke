using NUnit.Framework;
using Aikido.Application.Uke.Models;
using Aikido.Application.Uke.Interfaces;
using Aikido.Domain.Uke.Entities;
using Moq;

namespace Aikido.Application.Uke.Tests
{
    [TestFixture]
    public class UkeModelTests
    {
        private IDoAtemi _uke;
        private Mock<IProvideAtemi> _atemiProviderMock;

        [SetUp]
        public void UkeModel()
        {
            _atemiProviderMock = new Mock<IProvideAtemi>();
            _uke = new UkeModel(_atemiProviderMock.Object);
        }

        [TestCase("tsuki")]
        [TestCase("shomen uchi")]
        [TestCase("yokomen uchi")]
        public void ExecuteAtemiShouldReturnExpectedResult(string value)
        {
            _atemiProviderMock.Setup(a => a.Get()).Returns(new Atemi(value)); 
            
            var atemi = _uke.ExecuteAtemi();
            
            _atemiProviderMock.Verify(u => u.Get(), Times.Once());
            Assert.AreEqual(value, atemi.Name);
            
            Assert.Pass();
        }

        [TestCase("tsuki")]
        [TestCase("shomen uchi")]
        [TestCase("yokomen uchi")]
        public void ToStringShouldReturnFormattedResult(string value)
        {
            _atemiProviderMock.Setup(a => a.Get()).Returns(new Atemi(value)); 

            var atemi = _uke.ExecuteAtemi();

            _atemiProviderMock.Verify(u => u.Get(), Times.Once());
            Assert.AreEqual(string.Format("uke attacks using {0}", value), atemi.ToString());

            Assert.Pass();
        }
    }
}