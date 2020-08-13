using Microsoft.EntityFrameworkCore;
using PrekFlay.API.Models;

namespace PrekFlay.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        public DbSet<Value> values { get; set; }
    }
}