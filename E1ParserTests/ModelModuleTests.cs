using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E1Parser.Tests {
    [TestClass()]
    public class ModelModuleTests {
        [TestMethod()]
        public void ModelModuleTest() {
            Model e1Model = new ModelModule();
            Assert.IsTrue(e1Model != null);
        }

        [TestMethod()]
        public void RegisterObserverTest() {
            Model e1Model = new ModelModule();
            RegisterObserverTestView viewEmulator = new RegisterObserverTestView();

            e1Model.RegisterObserver(viewEmulator);

            e1Model.RefreshContent();
            bool isTestPassed = viewEmulator.IsTestPassed;
            Assert.IsTrue(isTestPassed);
        }

        [TestMethod()]
        public void RefreshContentTest() {
            Model e1Model = new ModelModule();
            RefreshContentTestView viewEmulator = new RefreshContentTestView();

            e1Model.RegisterObserver(viewEmulator);

            e1Model.RefreshContent();
            bool isTestPassed = viewEmulator.IsTestPassed;
            Assert.IsTrue(isTestPassed);
        }
    }
}