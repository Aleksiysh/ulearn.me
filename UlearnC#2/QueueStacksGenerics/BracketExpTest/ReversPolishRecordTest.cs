using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueStacksGenerics;

namespace BracketExpTest
{
    /// <summary>
    /// Сводное описание для ReversPolishRecordTest
    /// </summary>
    [TestClass]
    public class ReversPolishRecordTest
    {
        void Test(string str, int result)
        {
            Assert.AreEqual(result,ReversPolishRecord.Compute(str));
        }
        
        [TestMethod]
        public void SimpleTest()
        {
            Test("23+5*",25);
        }
        [TestMethod]
        public void SimpleTest2()
        {
            Test("23+5*2*", 50);
        }
        [TestMethod]
        public void SimpleTest3()
        {
            Test("23+5*2-", 23);
        }
        [TestMethod]
        public void SimpleTest4()
        {
            Test("23+5*5/", 5);
        }
        [TestMethod]
        public void SimpleTest5()
        {
            Test("23+5*2/", 12);
        }        
    }
}
