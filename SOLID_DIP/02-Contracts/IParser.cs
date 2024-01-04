using SOLID_Entities;
using System.Collections.Generic;

namespace SOLID_DIP
{
    public interface IParser
    {
        List<Person> Parse(string data);
    }
}