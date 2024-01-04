using SOLID_Entities;
using System.Collections.Generic;

namespace SOLID_DIP
{
    public class CamleCaseJsonSerializer : IDocumentSerializer
    {
        public string Serilize(List<Person> doc)
        {
            return new CamleCaseJsonSerializer().Serilize(doc);
        }
    }
}