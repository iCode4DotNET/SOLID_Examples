using Newtonsoft.Json;
using SOLID_Entities;
using SOLID_OCP.Contracts;
using System.Collections.Generic;

namespace SOLID_OCP
{
    public class JsonDocumentSerializer : IDocumentSerializer
    {
        public string Serilize(List<Person> doc)
        {
            return JsonConvert.SerializeObject(doc);
        }
    }
}