using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class SingletonTest
    {

        [TestMethod]
        public void Should_Have_Same_Instance()
        {
            var instance1 = Singleton.Singleton.Instance;
            var instance2 = Singleton.Singleton.Instance;

            Assert.ReferenceEquals(instance1, instance2);
        }

    }
}
