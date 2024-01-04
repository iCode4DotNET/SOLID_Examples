using System;
using System.IO;
using Unity;

namespace SOLID_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFileName = Path.Combine(Environment.CurrentDirectory, @"Input Dcocuments\Person.csv");
            var targetFileName = Path.Combine(Environment.CurrentDirectory, @"Output Dcocuments\Person.json ");


            sourceFileName = Path.Combine(Environment.CurrentDirectory, @"Input Dcocuments\Person.xml");
            sourceFileName = "https://soroushsadr.com";

            var container = GetContainer();

            FormatConverter obj1 = new FormatConverter(new CamleCaseJsonSerializer(), new InputParser());

            FormatConverter obj2 = container.Resolve<FormatConverter>();
           
            if (!obj2.ConvertFormat(sourceFileName, targetFileName))
            {
                Console.WriteLine("Conversion Failed");
                Console.ReadKey();
            }
        }



        //https://www.tutorialsteacher.com/ioc/ioc-container
        //https://www.claudiobernasconi.ch/2019/01/24/the-ultimate-list-of-net-dependency-injection-frameworks/

        private static IUnityContainer GetContainer()
        {
            IUnityContainer container = new UnityContainer();
         
            container.RegisterType<IDocumentSerializer, JsonDocumentSerializer>();
            container.RegisterType<InputParser, XmlInputParser>();
            return container;
        }

    }
}

