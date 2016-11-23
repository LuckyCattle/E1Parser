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
        public void ActivateTest() {
            ActivateTestView viewEmulator = new ActivateTestView();
            Controller controller = new ControllerModule();
            controller.BindWithView(viewEmulator);

            controller.Activate();

            bool isTestPassed = viewEmulator.IsTestPassed;
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

        [TestMethod()]
        public void BindWithViewTest() {
            ActivateTestView viewEmulator = new ActivateTestView();
            Controller controller = new ControllerModule();

            controller.BindWithView(viewEmulator);

            controller.Activate();
            bool isTestPassed = viewEmulator.IsTestPassed;
            Assert.IsTrue(isTestPassed);
        }
    }
}
