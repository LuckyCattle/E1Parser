using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace E1Parser.Tests {
    [TestClass()]
    public class ViewModuleTests {
        [TestMethod()]
        public void ViewModuleTest() {
            MainWindow window = new MainWindow();
            View viewExample  = new ViewModule(window);
            Assert.IsTrue(viewExample != null);
        }
    }
}