using SOLID_Entities;
using System.Collections.Generic;

namespace SOLID_ISP
{
    public interface IDocumentSerializer
    {
        string Serilize(List<Person> doc);
    }
}