using System;

namespace CSharpTest.Models
{
    public class Printers
    {
        public int Id { get; set; }
        public string PrinterName { get; set; }
        public string SerialKey { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CustomerName { get; set; }
    }
}
