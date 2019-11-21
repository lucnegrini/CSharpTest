using CSharpTest.Domain.Printer;
using CSharpTest.Domain.Printer.Interfaces;
using Ninject.Modules;

namespace CSharpTest
{
    public class BindingNinject : NinjectModule
    {
        public override void Load()
        {
            Bind<IPrinterRepository>().To<PrinterRepository>();
            Bind<IPrinterService>().To<PrinterService>();
            Bind<IPrinterFactory>().To<PrinterFactory>();
        }
    }
}
