using AutoFixture;
using AutoFixture.AutoMoq;
using IndustrialProtocol.Controllers;
using IndustrialProtocol.Models;
using Moq;
using NUnit.Framework;
using System.Text;

namespace Console.Test
{
    public class Tests
    {
        static IFixture _fixture;
        Mock<ReadParameters> MockTestPar = new Mock<ReadParameters>();
        Mock<Protocol> MockTestRead = new Mock<Protocol>();
        static void demoFunction(byte[] payback, bool err)
        {
            if (err)
            {
                string str = Encoding.Default.GetString(payback);
            }
            else
            {
                string str = "Error";
            }
        }
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());
            MockTestPar.Object.intStart = _fixture.Create<int>();
            MockTestPar.Object.intLength = _fixture.Create<int>();
            MockTestPar.Object.actPayload = demoFunction;
            var parametersRead = new ReadParameters();
            Protocol ctrPru = new Protocol();
            ctrPru.get(MockTestPar.Object);
            bool ret = ctrPru.get(MockTestPar.Object);
            Assert.IsTrue(ret);
        }
    }
}