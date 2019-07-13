using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueStacksGenerics;

namespace BracketExpTest
{
    [TestClass]
    public class BracketExpTest
    {
        void Test(string str, bool result)
        {
            Assert.AreEqual(result, BracketExp.Check(str));
        }

        [TestMethod]
        public void RightSequence()
        {
            Test("()(([[()]]))", true);            
        }

        [TestMethod]
        public void TooMuchOpenBrackets()
        {
            Test("(([[]]", false);
        }

        [TestMethod]
        public void TooMuchClosedBrackets()
        {
            Test("())", false);
        }

        [TestMethod]
        public void BreckatsIsNotMatch()
        {
            Test("(]", false);
        }

        [TestMethod]
        public void EmptyString()
        {
            Test("", true);
        }

        [TestMethod]
        public void NotBrackets()
        {
            Test("asd", true);
        }

        [TestMethod]
        public void NotBracketsAndBrackets()
        {
            Test("asd)", false);
        }

        [TestMethod]
        public void NotBracketsAndBracketsOk()
        {
            Test("(asd)", true);
        }

        [TestMethod]
        public void NotBracketsAndBracketsOk2()
        {
            Test("[(asd)[df]]", true);
        }
    }
}
