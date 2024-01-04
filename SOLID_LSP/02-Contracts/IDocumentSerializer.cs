using SOLID_Entities;
using System.Collections.Generic;

namespace SOLID_LSP
{
    public interface IDocumentSerializer
    {
        string Serilize(List<Person> doc);
    }
}