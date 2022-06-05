using CreatePDF.Models;
using Microsoft.EntityFrameworkCore;

namespace CreatePDF.Data
{
    public class Appcont : DbContext
    {
        public Appcont(DbContextOptions<Appcont> options) : base(options)
        {

        }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
