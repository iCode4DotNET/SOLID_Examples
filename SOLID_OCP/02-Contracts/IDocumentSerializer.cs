using SOLID_Entities;
using System.Collections.Generic;

namespace SOLID_OCP.Contracts
{
    public interface IDocumentSerializer
    {
        string Serilize(List<Person> doc);
    }
}
