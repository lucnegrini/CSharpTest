using CSharpTest.Domain.Printer.Interfaces;
using CSharpTest.Models;
using System;
using System.Collections.Generic;

namespace CSharpTest.Domain.Printer
{
    public class PrinterFactory : IPrinterFactory
    {
        public List<Printers> ParsePrinterList(List<PrinterInfo> oldList)
        {
            var newList = new List<Printers>();
            foreach(var oldPrinter in oldList)
            {
                newList.Add(new Printers()
                {
                    PrinterName = oldPrinter.Name,
                    SerialKey = oldPrinter.SerialKey,
                    CustomerName = oldPrinter.Customer.Name,
                    ExpireDate = DateTime.Now.AddHours(1)
                });
            }

            return newList;
        }
    }
}
