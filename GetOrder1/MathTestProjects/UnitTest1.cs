using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathComponentsNameSpace;
namespace MathTestProjects
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MathComponents obj = new MathComponents();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);

        }

        [TestMethod]
        public void TestSubstract()
        {
            MathComponents obj = new MathComponents();
            int result = obj.Substract(60, 10);
            Assert.AreEqual(50, result);
        }
    }
}
