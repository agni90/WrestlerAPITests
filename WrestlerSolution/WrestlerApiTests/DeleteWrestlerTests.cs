using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WrestlerSolution;
using WrestlerSolution.Exceptions;
using WrestlerSolution.Models.Requests;
using WrestlerSolution.Models.Responses;

namespace WrestlerApiTests
{
    [TestClass]
    public class DeleteWrestlerTests
    {
        [TestMethod]
        public void When_UserExistInDB_Expect_SuccessfulDeletion()
        {
            //Assign
            int testId = 3792;
            var client = new WrestlerClient("auto", "test");
            var request = new DeleteWrestlerRequest
            {
                Id = testId
            };
            //Act
            var response = client.DeleteWrestler(request);
            //Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.result);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFoundException))]
        public void When_UserDoesNotExistInDB_Expect_UserNotFoundError()
        {
            //Assign
            int testId = 0000;
            var client = new WrestlerClient("auto", "test");
            var request = new DeleteWrestlerRequest
            {
                Id = testId
            };
            //Act
            var response = client.DeleteWrestler(request);      
        }

        [TestMethod]
        [ExpectedException(typeof(NotFoundException))]
        public void When_PassNegativeId_Expect_UserNotFoundError()
        {
            //Assign
            int testId = -666;
            var client = new WrestlerClient("auto", "test");
            var request = new DeleteWrestlerRequest
            {
                Id = testId
            };
            //Act
            var response = client.DeleteWrestler(request);
        }
    }
}
