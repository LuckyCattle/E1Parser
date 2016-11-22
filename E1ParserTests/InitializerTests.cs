using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E1Parser.Tests {
    [TestClass()]
    public class InitializerTests {
        [TestMethod()]
        public void BuildApplicationTest() {
            BaseForm mainWindow = new BaseForm();
            Initializer.BuildApplication(mainWindow);
        }

        [TestMethod()]
        public void StartApplicationTest() {
            BaseForm mainWindow = new BaseForm();
            Initializer.BuildApplication(mainWindow);
            Initializer.StartApplication();
        }
    }
}