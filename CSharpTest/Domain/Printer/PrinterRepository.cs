using CSharpTest.Domain.Printer.Interfaces;
using CSharpTest.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace CSharpTest.Domain.Printer
{
    public class PrinterRepository : IPrinterRepository
    {
        private readonly string connString;
        public PrinterRepository()
        {
            connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void InsertPrinters(List<Printers> printers)
        {
            using (var context = new Context(connString))
            {
                context.Printers.AddRange(printers);
                context.SaveChanges();
            }
        }

        public List<Printers> FindAllPrinters()
        {
            var result = new List<Printers>();
            using (var context = new Context(connString))
            {
                result = context.Printers.ToList();
            }

            return result;
        }
    }
}
