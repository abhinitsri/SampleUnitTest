 using System;
 using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DemoClass obj = new DemoClass();
            Assert.AreEqual("Abhishek", obj.fname);
            Assert.AreEqual("Kumar", obj.lname);
        }
    }
}
