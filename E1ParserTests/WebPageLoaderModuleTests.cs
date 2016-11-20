using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace E1Parser.Tests {
    [TestClass()]
    public class WebPageLoaderModuleTests {
        [TestMethod()]
        public void GetPageCodeTest() {
            WebPageLoader loader = new WebPageLoaderModule();

            string e1PageCode = loader.GetPageCode("http://www.e1.ru/afisha/events/art");
            
            //FIXME:debug//////////////////////////////////////////////////////
            /*FileStream filewriter = new FileStream("./debug.log", FileMode.Create);
            StreamWriter writer = new StreamWriter(filewriter);
            writer.Write(e1PageCode);
            writer.Close();*/
            ///////////////////////////////////////////////////////////////////

            bool isCorrect = e1PageCode.Contains("favicon.ico");
            Assert.IsTrue(isCorrect);
        }
    }
}
