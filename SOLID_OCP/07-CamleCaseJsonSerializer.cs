using SOLID_Entities;
using SOLID_OCP.Contracts;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SOLID_OCP
{
    public class CamleCaseJsonSerializer : IDocumentSerializer
    {
        public string Serilize(List<Person> doc)
        {
            // return new CamleCaseJsonSerializer().Serilize(doc);

           // return  JsonConvert.SerializeObject(doc, formatting: Formatting.Indented);


            return  JsonConvert.SerializeObject(doc, 
                                                formatting: Formatting.Indented,
                                                settings:
                                                new JsonSerializerSettings
                                                {
                                                     ContractResolver = new CamelCasePropertyNamesContractResolver()
                                                });


        }
    }
}