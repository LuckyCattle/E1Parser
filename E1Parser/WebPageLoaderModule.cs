using System.IO;
using System.Net;

namespace E1Parser {
    sealed class WebPageLoaderModule : WebPageLoader {
        public string GetPageCode(string pageURI) {
            WebRequest request = WebRequest.Create(pageURI);
            WebResponse response  = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string pageCode = reader.ReadToEnd();
            response.Close();

            //FIXME:debug//////////////////////////////////////////////////////
            FileStream filewriter = new FileStream("./debug.log", FileMode.Create);
            StreamWriter writer = new StreamWriter(filewriter);
            writer.Write(pageCode);
            ///////////////////////////////////////////////////////////////////

            return pageCode;
        }
    }
}
