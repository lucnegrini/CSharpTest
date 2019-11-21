using CSharpTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpTest.Domain.Printer.Interfaces
{
    public interface IPrinterService
    {
        Task<List<PrinterInfo>> GetPrinters();
    }
}
