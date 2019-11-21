using System.Collections.Generic;
using System.Linq;
using WebApiTest.Models;

namespace WebApiTest
{
    public static class VirtualDatabase
    {
        private static readonly List<PrinterInfo> Printers = new List<PrinterInfo>() { 
            new PrinterInfo()
            {
                Name = "Printer 1",
                SerialKey = "1234",
                Customer = new Customer(){Name = "Customer 1", Id = 1}
            },
            new PrinterInfo()
            {
                Name = "Printer 2",
                SerialKey = "5678",
                Customer = new Customer(){Name = "Customer 2", Id = 2}
            },

        };

        public static List<PrinterInfo> GetAllPrinters()
        {
            return Printers;
        }
        public static List<PrinterInfo> GetPrinterInfoByName(string name)
        {
            return Printers.Where(p => p.Name == name).ToList();
        }

        public static void InsertPrinterInfoList(List<PrinterInfo> list)
        {
            Printers.AddRange(list);
        }

        public static void ClearDatabase()
        {
            Printers.Clear();
        }
    }
}