

using Microsoft.EntityFrameworkCore;
using Patel_Inventory_Accounts.Models;

namespace Patel_Inventory_Accounts.DB
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)

        {

        }

        public DbSet<Class_Companies> tbl_companies { get; set; }
        public DbSet<Class_Branches> tbl_branches { get; set; }
    }
}
