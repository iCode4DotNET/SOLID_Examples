using SOLID_Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace SOLID_Project_Ver_0
{
    class Program
    {
        static void Main(string[] args)
        {

            //Install-Package System.Text.Json ................


            var sourceFileName = Path.Combine(Environment.CurrentDirectory, @"Input Documents\Person.csv ");
            var targetFileName = Path.Combine(Environment.CurrentDirectory, @"Output Documents\DotinPerson.json ");

            //F:\IT\Dotin\BootCamp\C#\SOLID_Examples\SOLID_Project_Ver_0\bin\Debug\Input Documents\Person.csv 

            string input;

            using (FileStream stream = File.OpenRead(sourceFileName))
            using (StreamReader reader = new StreamReader(stream))
            {
                input = reader.ReadToEnd();
            }

            string[] personRead = input.Split('\n');

            List<Person> people = new List<Person>();

            foreach (string item in personRead)
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
       
            var serializedPeople = Newtonsoft.Json.JsonConvert.SerializeObject(people);

            using (var stream = File.Open(targetFileName, FileMode.Create, FileAccess.Write))
            using (var sw = new StreamWriter(stream))
            {
                sw.Write(serializedPeople);
            }
        }
    }
}