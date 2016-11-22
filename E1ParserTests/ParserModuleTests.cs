using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace E1Parser.Tests {
    [TestClass()]
    public class ParserModuleTests {
        [TestMethod()]
        public void ParserModuleTest() {
            WebPageLoader loader = new WebPageLoaderModule();
            Parser parser = new ParserModule(loader);
            Assert.IsTrue(parser != null);
        }

        [TestMethod()]
        public void ExtractEventsTest() {
            WebPageLoader loader = new WebPageLoaderModule();
            Parser parser = new ParserModule(loader);

            List<Event> events = parser.ExtractEvents();

            Assert.IsTrue(events.Count > 0);
            foreach (Event eachEvent in events) {
                Assert.IsTrue(eachEvent.Name.Length > 0);
                Assert.IsTrue(eachEvent.Date.Length > 0);
                Assert.IsTrue(eachEvent.Place.Length > 0);
                Assert.IsTrue(eachEvent.Address.Length > 0);
            }
        }
    }
}