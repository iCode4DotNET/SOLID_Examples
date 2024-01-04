using Newtonsoft.Json;
using SOLID_Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace SOLID_Project_Ver_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFileName = Path.Combine(Environment.CurrentDirectory, @"Input Dcocuments\Person.csv ");
            var targetFileName = Path.Combine(Environment.CurrentDirectory, @"Output Dcocuments\Person.json ");

            var input = GetInput(sourceFileName);
            var people = GetPeople(input);
            var serializedPeople = SerializedPeople(people);
            PersistPeople(serializedPeople, targetFileName);
        }
   
        private static List<Person> GetPeople(string input)
        {
            string[] personRead = input.Split('\n');
            List<Person> people = new List<Person>();

            foreach (var item in personRead)
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

        private static string GetInput(string sourceFileName)
        {
            string input;
            using (var stream = File.OpenRead(sourceFileName))
            using (var reader = new StreamReader(stream))
            {
                input = reader.ReadToEnd();
            }
            return input;
        }

        private static void PersistPeople(object serializedPeople, string targetFileName)
        {
            using (var stream = File.Open(targetFileName, FileMode.Create, FileAccess.Write))
            using (var sw = new StreamWriter(stream))
            {
                sw.Write(serializedPeople);
                sw.Close();
            }
        }

        private static string SerializedPeople(List<Person> people)
        {
            var serializedPeople = JsonConvert.SerializeObject(people);
            return serializedPeople;

        }
    }
}