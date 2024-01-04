using SOLID_OCP.BaseClasses;
using System;
using System.IO;
using System.Net;

namespace SOLID_OCP
{

    public class HttpInputRetriever : DocumentStorage
    {
        public override string GetData(string sourceFileName)
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

        public override void PersistDocument(object serializedDoc, string targetFileName)
        {
            throw new NotImplementedException();
        }
    }
}