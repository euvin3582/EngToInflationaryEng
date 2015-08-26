using System;
using InflationaryEng;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngToInflationaryEng
{
    [TestClass]
    public class TestConvertWords
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testString = "Once upon a time three ducks came home for lunch. They were trying to " +
                "figure out how too cross the road around five a car drove by.  They were taken by " +
                "surprise for the road was not ment to be driven on.";

            string testResult = "Once upon a time Four ducks came home Five lunch. They were trying Three " + 
                "figure out how Three cross the road around Six a car drove by.  They were taken by surprise " +
                "Five the road was not ment Three be driven on.";

            ConvertWords converter = new ConvertWords();
            string output = converter.ConvertInput(testString);

            Assert.AreEqual(output, testResult);
        }
    }
}
