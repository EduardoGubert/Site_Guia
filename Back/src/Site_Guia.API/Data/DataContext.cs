using Microsoft.EntityFrameworkCore;
using Site_Guia.API.Models;

namespace Site_Guia.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Site> Sites { get; set; }
    }
}