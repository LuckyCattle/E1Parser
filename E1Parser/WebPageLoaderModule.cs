using System;
using System.IO;
using System.Net;

namespace E1Parser {
    public sealed class WebPageLoaderModule : WebPageLoader {
        public string GetPageCode(string pageURI) {
            WebRequest request = WebRequest.Create(pageURI);
            WebResponse response  = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string pageCode = reader.ReadToEnd();
            response.Close();
            return pageCode;
        }
    }
}
