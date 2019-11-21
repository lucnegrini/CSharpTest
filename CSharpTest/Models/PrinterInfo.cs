using System.Collections.Generic;

namespace CSharpTest.Models
{
    public class PrinterInfo
    {
        public string Name { get; set; }
        public string SerialKey { get; set; }
        public Customer Customer { get; set; }

        public PrinterInfo()
        {
            Name = "";
            SerialKey = "";
            Customer = new Customer();
        }
    }
}