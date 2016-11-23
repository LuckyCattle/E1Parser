using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E1Parser.Tests {
    [TestClass()]
    public class InitializerTests {
        [TestMethod()]
        public void BuildApplicationTest() {
            Initializer.BuildApplication();
        }

        [TestMethod()]
        public void GetControllerTest() {
            Initializer.BuildApplication();

            Controller actual = Initializer.GetController();

            Assert.IsTrue(actual != null);
        }
    }
}