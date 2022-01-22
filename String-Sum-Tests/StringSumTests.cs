using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_Sum_Library;
using System;

namespace String_Sum_Tests
{
    [TestClass]
    public class StringSumTests
    {
        //String Sum
        //Given a string that has integers space-separated.
        //Add all of the integers and return the sum.

        //Input       Output
        //"1 2 3 4"	    10
        //"1 5 2"		8
        //"4"		    4

        [TestMethod]
        public void StringSum_InputString_Validate()
        {
            try
            {
                StringSum.Sum("1");
            }
            catch(Exception ex)
            {
                Assert.IsFalse(ex != null);
                return;
            }

            Assert.IsFalse(false);
        }

        [TestMethod]
        public void StringSum_Input4DigitAsString_Return4DigitAsInteger()
        {
            Assert.AreEqual(4, StringSum.Sum("4"));
        }

        [TestMethod]
        [DataRow("1", 1)]
        [DataRow("2", 2)]
        [DataRow("3", 3)]
        [DataRow("4", 4)]
        public void StringSum_InputSingleDigitAsString_ReturnSingleDigitAsInteger(string input, int expected)
        {
            Assert.AreEqual(expected, StringSum.Sum(input));
        }

        [TestMethod]
        [DataRow("a")]
        [DataRow("h")]
        [DataRow("-")]
        [DataRow("}")]
        public void StringSum_InputSingleAlphaAsString_ReturnArgumentException(string input)
        {
            Assert.ThrowsException<ArgumentException>(() => StringSum.Sum(input));
        }

        [TestMethod]
        [DataRow("1 1", 2)]
        [DataRow("1 2", 3)]
        [DataRow("1 3", 4)]
        [DataRow("1 4", 5)]
        public void StringSum_InputTwoDigitsAsString_ReturnSingleSumAsInteger(string input, int expected)
        {
            Assert.AreEqual(expected, StringSum.Sum(input));
        }

        [TestMethod]
        [DataRow("1 1 1", 3)]
        [DataRow("1 2 1", 4)]
        [DataRow("1 3 1", 5)]
        [DataRow("1 4 1", 6)]
        public void StringSum_InputThreeDigitsAsString_ReturnSingleSumAsInteger(string input, int expected)
        {
            Assert.AreEqual(expected, StringSum.Sum(input));
        }
    }
}
