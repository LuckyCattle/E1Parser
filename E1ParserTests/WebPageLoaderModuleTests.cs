using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E1Parser.Tests {
    [TestClass()]
    public class WebPageLoaderModuleTests {
        [TestMethod()]
        public void GetPageCodeTest() {
            WebPageLoader loader = new WebPageLoaderModule();

            string e1PageCode = loader.GetPageCode("http://www.e1.ru/afisha/events/art");

            bool isCorrect = e1PageCode.Contains("favicon.ico");
            Assert.IsTrue(isCorrect);
        }
    }
}
