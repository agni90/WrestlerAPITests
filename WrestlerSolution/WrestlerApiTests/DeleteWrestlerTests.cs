using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WrestlerSolution;
using WrestlerSolution.Exceptions;

namespace WrestlerApiTests
{
    [TestClass]
    public class DeleteWrestlerTests
    {
        [TestMethod]
        public void When_UserExistInDB_Expect_SuccessfulDeletion()
        {
            //Assign
            int testId = 3629;
            var client = new WrestlerClient("auto", "test");
            //Act
            var response = client.DeleteWrestler(testId);
            var wrestler = Converter.JsonResponseToWrestler(response);
            //Assert
            Assert.IsNotNull(wrestler); //expected result - result:true
        }

        [TestMethod]
        public void When_UserDoesNotExistInDB_Expect_UserNotFoundError()
        {
            //Assign
            int testId = 0000;
            var client = new WrestlerClient("auto", "test");
            //Act
            var response = client.DeleteWrestler(testId);
            var wrestler = Converter.JsonResponseToWrestler(response);
            //Assert
            Assert.Equals(NotFoundException, "tesst");
        }
    }
}
