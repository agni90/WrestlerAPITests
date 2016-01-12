using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WrestlerSolution;
using WrestlerSolution.Models;

namespace WrestlerApiTests
{
    [TestClass]
    public class UpdateWrestlerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var wrestler = new SimpleWrestler
            {
                fname = "New test",
                lname = "test",
                mname = "test",
                dob = "25-05-1994",//DateTime.Now.ToString("dd-MM-yyyy"),
                region1 = 3,
                fst1 = 2,
                style = 1,
                lictype = 1,
                card_state = 1,
                expires = 2015
            };
            var wrestlerJson = Converter.SimpleWrestlerToJsonRequest(wrestler);
            var client = new WrestlerClient("auto", "test");
            //Act
            var result = client.CreateWrestler(wrestlerJson);
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
