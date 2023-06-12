using CRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUD.DATA
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
