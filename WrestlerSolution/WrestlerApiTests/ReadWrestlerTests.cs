using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WrestlerSolution;
using WrestlerSolution.Models;

namespace WrestlerApiTests
{
    [TestClass]
    public class ReadWrestlerTests
    {
        [TestMethod]
        public void Precondition_result()
        {
            //Assign
            int testId = 3629;
            var client = new WrestlerClient("auto", "test", "bdp9fmp9r7upcjdg1985e14s15");
            //Act
            var response = client.ReadWrestlerById(testId);
            var wrestler = Converter.JsonResponseToWrestler(response);
            //Assert
            Assert.IsNotNull(wrestler);
        }
    }
}
