using CSharpTest.Domain.Printer.Interfaces;
using Newtonsoft.Json;
using Ninject;
using System;
using System.Reflection;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Press any key to start");
                Console.ReadKey();

                var di = new StandardKernel();
                di.Load(Assembly.GetExecutingAssembly());
                var printerService = di.Get<IPrinterService>();
                var printerRepository = di.Get<IPrinterRepository>();
                var printerFactory = di.Get<IPrinterFactory>();

                Console.WriteLine($"{Environment.NewLine}Retrieving printers list from WebAPI...");
                var apiReturn = printerService.GetPrinters().Result;
                Console.WriteLine("Done!");

                Console.WriteLine("Saving data into local database...");
                var printerInfo = printerFactory.ParsePrinterList(apiReturn);
                printerRepository.InsertPrinters(printerInfo);
                Console.WriteLine("Done!");

                Console.WriteLine("Retrieving all printers data from database...");
                var printers = printerRepository.FindAllPrinters();

                Console.WriteLine(JsonConvert.SerializeObject(printers));

                Console.WriteLine("Done!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occoured while runnig the program: {ex}");
                Console.ReadKey();
            }
        }
    }
}
