using System;
using System.IO;
using System.Net;
using System.Reflection;

namespace SOLID_DIP
{
    public class HttpInputRetriever : IInputRetriever
    {
        public string GetData(string sourceFileName)
        {
            if (!sourceFileName.StartsWith("https://"))
                throw new Exception("آدرس سایت معتبر نمیباشد");

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(sourceFileName);
            request.Method = "GET";
            String input = "";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        input = reader.ReadToEnd();
                    }
                }
            }
            return input;
        }

    }
}