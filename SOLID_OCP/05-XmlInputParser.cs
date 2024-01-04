using SOLID_Entities;
using SOLID_OCP.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SOLID_OCP
{
    public class XmlInputParser : InputParser
    {
        public override List<Person> ParseInput(string input)
        {
            try
            {
                var xDoc = XDocument.Parse(input);
                IEnumerable<XElement> rootElements;
              
                rootElements = xDoc.Root.Elements();

                Person[] people = new Person[rootElements.Count()];
             
                for (int index = 0; index < people.Length; index++)
                {
                    var xPerson = rootElements.ElementAt(index).Elements().ToArray();
                  
                    Person student = new Person()
                    {
                        ID = int.Parse(xPerson[3].Value),
                        Name = xPerson[1].Value,
                        Family = xPerson[2].Value,
                        Birthdate = DateTime.Parse(xPerson[0].Value)
                    };
                    people[index] = student;
                }
                return people.ToList();
            }
            catch (Exception)
            {
                throw new InvalidInputFormatException();
            }
        }
    }

}