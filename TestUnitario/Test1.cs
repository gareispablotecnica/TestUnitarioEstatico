using CapaLogica;

namespace TestUnitario
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool test = CapaLogica.ValidacionLogin.Login("Admin","1234");
            Assert.IsTrue(test);
        }
    }
}
