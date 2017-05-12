using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using FactoryMethod;

namespace Test
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void Should_Construct_Bed_Room()
        {
            var room = new BedRoom();
            var elements = new List<Element>()
            {
                new Bed(),new Desk(), new Computer()
            };

            Assert.IsTrue(room.Elements.SequenceEqual(elements, new ElementEqualityComparer()));
        }

        [TestMethod]
        public void Should_Construct_Living_Room()
        {
            var room = new LivingRoom();
            var elements = new List<Element>()
            {
                new Television(),new Kitchen(), new Chair()
            };

            Assert.IsTrue(room.Elements.SequenceEqual(elements, new ElementEqualityComparer()));
        }
    }


    public class ElementEqualityComparer : IEqualityComparer<Element>
    {
        public bool Equals(Element x, Element y)
        {
            if (object.ReferenceEquals(x, y)) return true;

            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null)) return false;

            return x.GetType().Name == y.GetType().Name;
        }

        public int GetHashCode(Element obj)
        {
            if (object.ReferenceEquals(obj, null)) return 0;

            int hashCodeName = obj.GetType().Name == null ? 0 : obj.GetType().Name.GetHashCode();

            return hashCodeName;
        }
    }
}
