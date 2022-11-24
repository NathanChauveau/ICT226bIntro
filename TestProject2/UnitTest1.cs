using Model;
using System.Runtime.CompilerServices;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private A a = null;
       
        [TestInitialize]
        public void Setup()
        {
            a = new A();
        }
        [TestMethod]
        public void TestA()
        {
            Assert.AreEqual(a.ToString(), "Coucou je suis A");
        }
    }
}