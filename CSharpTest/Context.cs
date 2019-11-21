using CSharpTest.Models;
using System.Data.Entity;

namespace CSharpTest
{
    public class Context : DbContext
    {
        public Context(string connectionString) : base(connectionString) { }

        public DbSet<Printers> Printers { get; set; }
    }
}
