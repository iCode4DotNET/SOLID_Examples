using System;
using System.IO;

namespace SOLID_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFileName = Path.Combine(Environment.CurrentDirectory, @"Input Dcocuments\Person.csv");
            var targetFileName = Path.Combine(Environment.CurrentDirectory, @"Output Dcocuments\Person.json ");


            sourceFileName = Path.Combine(Environment.CurrentDirectory, @"Input Dcocuments\Person.xml");
            sourceFileName = "https://icode4.net";

            //var formatConverter =new FormatConverter(new InputParser(),new JsonDocumentSerializer());
            //var formatConverter = new FormatConverter(new JsonDocumentSerializer(),new InputParser());
            var formatConverter = new FormatConverter(new TestSerializer(), new InputParser());



            if (!formatConverter.ConvertFormat(sourceFileName, targetFileName))
            {
                Console.WriteLine("Conversion Failed");
                Console.ReadKey();
            }
        }
    }
}

