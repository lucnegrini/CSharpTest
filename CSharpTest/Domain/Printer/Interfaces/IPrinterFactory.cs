using CSharpTest.Models;
using System.Collections.Generic;

namespace CSharpTest.Domain.Printer.Interfaces
{
    public interface IPrinterFactory
    {
        List<Printers> ParsePrinterList(List<PrinterInfo> oldList);
    }
}
