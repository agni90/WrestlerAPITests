using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WrestlerSolution;
using WrestlerSolution.Models;

namespace WrestlerApiTests
{
    [TestClass]
    public class CreateWrestlerTests
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void When_AllFieldsAreFilledByCorrectData_Expect_SuccessfulUseCreation()
        {
            //Assign
            var wrestler = new SimpleWrestler
            {
                fname = "test",
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

        [TestMethod]
        public void When_FirstNameFieldIsEmpty_Expect_Error()
        {
            //Assign
            var wrestler = new SimpleWrestler
            {
                fname = "",
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
            Assert.Fail();
        }

        [TestMethod]
        public void When_DobFieldIsEmpty_Expect_Error()
        {
            //Assign
            var wrestler = new SimpleWrestler
            {
                fname = "test",
                lname = "test",
                mname = "test",
                dob = "",//DateTime.Now.ToString("dd-MM-yyyy"),
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
            Assert.Fail();
        }

        [TestMethod]
        public void When_DobWasEnteredInWrongFormat_Expect_Error()
        {
            //Assign
            var wrestler = new SimpleWrestler
            {
                fname = "test",
                lname = "test",
                mname = "test",
                dob = "20150907",//DateTime.Now.ToString("dd-MM-yyyy"),
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
            Assert.Fail();
        }
    }
}
