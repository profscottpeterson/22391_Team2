using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoachConnect.Tests
{
       [TestClass]
       public class ValidationTest
    {

        [TestMethod]
        public void ValidateTextBox_Null()
        {
            Validation testValidate = new Validation();
            string test1 = "";
            bool expected = false;
            bool actual = testValidate.ValidateTextBox(test1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateTextBox_NonAlpha()
        {
            Validation testValidate = new Validation();
            string test1 = "!!Tim!!";
            bool expected = false;
            bool actual = testValidate.ValidateTextBox(test1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateEmail_Sans_At()
        {
            Validation testValidate = new Validation();
            string test1 = "notarealemail.com";
            bool expected = false;
            bool actual = testValidate.ValidateEmail(test1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateEmail()
        {
            Validation testValidate = new Validation();
            string test1 = "fake@fake.com";
            bool expected = true;
            bool actual = testValidate.ValidateEmail(test1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePhone_10plusDigits()
        {
            Validation testValidate = new Validation();
            string test1 = "1111111111111111111111111";
            bool expected = false;
            bool actual = testValidate.ValidatePhone(test1);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidatePhone_10minusDigits()
        {
            Validation testValidate = new Validation();
            string test1 = "11";
            bool expected = false;
            bool actual = testValidate.ValidatePhone(test1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePhone()
        {
            Validation testValidate = new Validation();
            string test1 = "9208675309";
            bool expected = true;
            bool actual = testValidate.ValidatePhone(test1);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CleanString()
        {
            Validation testValidate = new Validation();
            string test1 = "                 tIMOTHY     ";
            string expected = "Timothy";
            string actual = testValidate.CleanString(test1);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CleanString_OneCharacter()
        {
            Validation testValidate = new Validation();
            string test1 = "                 i     ";
            string expected = "I";
            string actual = testValidate.CleanString(test1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CleanNumber()
        {
            Validation testValidate = new Validation();
            string test1 = "      9!2 0yy8 TIMISAWESOME 6II75^^^3*[09:ASDFEE";
            string expected = "9208675309";
            string actual = testValidate.CleanNumber(test1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FormatPhone()
        {
            Validation testValidate = new Validation();
            string test1 = "9208675309";
            string expected = "(920)867-5309";
            string actual = testValidate.FormatPhone(test1);

            Assert.AreEqual(expected, actual);
        }
    }
}
