using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HouseWorkFactory;

namespace Test
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void Should_Do_Cooking()
        {
            var doThecooking = new DoTheCooking();

            var child = new Child(doThecooking);

            Assert.AreEqual(child.RunAction(),"Mother allow the Cooking");
        }

        [TestMethod]
        public void Sould_Forbid_Cleaning()
        {
            var wontDoTheCleaning = new WontDoTheCleaning();

            var child = new Child(wontDoTheCleaning);

            Assert.AreEqual(child.RunAction(), "Father forbid the Cleaning");
        }
    }
}
