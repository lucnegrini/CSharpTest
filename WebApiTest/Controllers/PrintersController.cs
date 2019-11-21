using System.Collections.Generic;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class PrintersController : ApiController
    {
        // GET api/printers
        [HttpGet]
        public IEnumerable<PrinterInfo> Get()
        {
            return VirtualDatabase.GetAllPrinters();
        }

        [HttpGet]
        public IEnumerable<PrinterInfo> GetByName(string name)
        {
            return VirtualDatabase.GetPrinterInfoByName(name);
        }

        [HttpPost]
        public IHttpActionResult InsertInfoList([FromBody] List<PrinterInfo> newList)
        {
            VirtualDatabase.InsertPrinterInfoList(newList);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult RemoveInfo()
        {
            VirtualDatabase.ClearDatabase();
            return Ok();
        }
    }
}
