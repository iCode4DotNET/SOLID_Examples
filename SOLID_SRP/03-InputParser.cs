using SOLID_Entities;
using System;
using System.Collections.Generic;

namespace SOLID_SRP
{
    public class InputParser
    {
        public List<Person> ParseInput(string input)
        {
            string[] data = input.Split('\n');
            List<Person> people = new List<Person>();

            foreach (var item in data)
            {
                string[] personData = item.Split(',');
                Person student = new Person()
                {
                    ID = int.Parse(personData[0]),
                    Name = personData[1],
                    Family = personData[2],
                    Birthdate = DateTime.Parse(personData[3])
                };
                people.Add(student);
            }

            return people;
        }
    }
}