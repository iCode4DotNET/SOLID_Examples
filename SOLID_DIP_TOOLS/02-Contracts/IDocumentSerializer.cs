using SOLID_Entities;
using System.Collections.Generic;

namespace SOLID_DIP
{
    public interface IDocumentSerializer
    {
        string Serilize(List<Person> doc);
    }
}