using CSharpTest.Models;
using System.Collections.Generic;

namespace CSharpTest.Domain.Printer.Interfaces
{
    public interface IPrinterRepository
    {
        void InsertPrinters(List<Printers> printers);
        List<Printers> FindAllPrinters();
    }
}
