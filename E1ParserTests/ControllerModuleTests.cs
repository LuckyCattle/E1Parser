using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E1Parser.Tests {
    [TestClass()]
    public class ControllerModuleTests {
        [TestMethod()]
        public void StartWorkTest() {
            ModelEmulator model = new ModelEmulator();
            Controller controller = new ControllerModule();
            controller.BindWithModel(model);

            controller.StartWork();

            bool isTestPassed = model.IsTestPassed;
            Assert.IsTrue(isTestPassed);
        }

        [TestMethod()]
        public void BindWithModelTest() {
            ModelEmulator model = new ModelEmulator();
            Controller controller = new ControllerModule();

            controller.BindWithModel(model);

            controller.StartWork();
            bool isTestPassed = model.IsTestPassed;
            Assert.IsTrue(isTestPassed);
        }
    }
}
