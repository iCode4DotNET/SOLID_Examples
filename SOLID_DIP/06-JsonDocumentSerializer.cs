using Newtonsoft.Json;
using SOLID_Entities;
using System.Collections.Generic;

namespace SOLID_DIP
{
    public class JsonDocumentSerializer : IDocumentSerializer
    {
        public string Serilize(List<Person> doc)
        {
            return JsonConvert.SerializeObject(doc);
        }
    }


    public class TestSerializer : IDocumentSerializer
    {
        // Runtime Error
        public string Serilize(List<Person> doc)
        {
            throw new System.NotImplementedException();
        }
    }

}