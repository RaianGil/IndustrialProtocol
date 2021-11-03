using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using IndustrialProtocol.Models;
using IndustrialProtocol.Controllers;

namespace Console.Test
{
    class testIndustrialProtocol
    {
        [TestMethod]
        public static void runGet_Error()
        {
            var parametersRead = new ReadParameters();
            var MockTestRead = new Mock<Protocol>();
            MockTestRead.Setup(sp => sp.get(parametersRead));
        }
    }
}
