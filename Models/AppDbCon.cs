using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOADMORE.Models
{
    public class AppDbCon : DbContext
    {
        public AppDbCon(DbContextOptions<AppDbCon> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
