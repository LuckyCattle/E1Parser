using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E1Parser.Tests {
    [TestClass()]
    public class ParserModuleTests {
        [TestMethod()]
        public void ParserModuleTest() {

        }

        [TestMethod()]
        public void extractEventsTest() {
            WebPageLoader loader = new WebPageLoaderModule();
            Parser parser = new ParserModule(loader);

            parser.ExtractEvents();
        }
    }
}