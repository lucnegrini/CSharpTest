using CSharpTest.Domain.Printer.Interfaces;
using CSharpTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

namespace CSharpTest.Domain.Printer
{
    public class PrinterService : IPrinterService
    {
        public PrinterService() { }

        public async Task<List<PrinterInfo>> GetPrinters()
        {
            try
            {
                return await "http://localhost:24520/api/printers".GetJsonAsync<List<PrinterInfo>>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
