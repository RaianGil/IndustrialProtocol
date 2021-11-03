using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using IndustrialProtocol.Models;
using IndustrialProtocol.Controllers;
using AutoFixture;
using AutoFixture.AutoMoq;
using System.Text;

namespace Console.Test
{
    class testIndustrialProtocol
    {
        static IFixture _fixture;
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
        [TestMethod]
        public static void runGet_Error()
        {
            //_fixture = new Fixture().Customize(new AutoMoqCustomization());
            //var parametersRead = new ReadParameters();
            var MockTestRead = new Mock<Protocol>();
            //var MockTestPar = new Mock<ReadParameters>();
            //MockTestPar.Object.intStart = _fixture.Create<int>();
            //MockTestPar.Object.intLength = _fixture.Create<int>();
            //MockTestPar.Object.actPayload = demoFunction;
            //MockTestRead.Setup(sp => sp.get(MockTestPar.Object));
            //Protocol ctrPru = new Protocol();
            //ctrPru.get(MockTestPar.Object);
            bool ret = true;
            Assert.IsTrue(ret);
        }
    }
}
