using System.IO;
using System.Net;
using System.Text;

namespace E1Parser {
    public sealed class WebPageLoaderModule : WebPageLoader {
        public string GetPageCode(string pageURI) {
            WebRequest request = WebRequest.Create(pageURI);
            WebResponse response  = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding(1251));
            string pageCode = reader.ReadToEnd();
            response.Close();
            return pageCode;
        }
    }
}
