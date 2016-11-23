using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E1Parser.Tests {
    [TestClass()]
    public class ViewModuleTests {
        [TestMethod()]
        public void ViewModuleTest() {
            View viewExample  = new ViewModule();
            Assert.IsTrue(viewExample != null);
        }

        [TestMethod()]
        public void BecomeVisibleTest() {
            View viewExample = new ViewModule();

            viewExample.BecomeVisible();
        }
    }
}