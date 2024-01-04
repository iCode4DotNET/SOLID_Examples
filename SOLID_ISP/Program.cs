using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFileName = Path.Combine(Environment.CurrentDirectory, @"Input Dcocuments\Person.csv");
            var targetFileName = Path.Combine(Environment.CurrentDirectory, @"Output Dcocuments\Person.json ");


            sourceFileName = Path.Combine(Environment.CurrentDirectory, @"Input Dcocuments\Person.xml");
           
            sourceFileName = "http://soroushsadr.com";

            var formatConverter = new FormatConverter();
            if (!formatConverter.ConvertFormat(sourceFileName, targetFileName))
            {
                Console.WriteLine("Conversion Failed");
                Console.ReadKey();
            }
        }
    }
}
