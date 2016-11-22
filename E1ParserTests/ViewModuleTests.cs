using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace E1Parser.Tests {
    [TestClass()]
    public class ViewModuleTests {
        [TestMethod()]
        public void ViewModuleTest() {
            BaseForm window = new BaseForm();
            View viewExample  = new ViewModule(window);
            Assert.IsTrue(viewExample != null);
        }
    }
}