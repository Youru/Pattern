using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Builder;
using Prototype;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class PrototypeTest
    {

        [TestMethod]
        public void Should_Clone_Ninja()
        {
            var ninja = new Ninja("Nanja");

            var characters = new List<Prototype.Prototype>();

            for (int i = 0; i < 45; i++)
            {
                characters.Add(ninja.Clone());
            }

            Assert.IsTrue(characters.All(x => x.Id == "Nanja"));
        }

    }
}
