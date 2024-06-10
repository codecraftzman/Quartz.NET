using Microsoft.EntityFrameworkCore;
using Quartz.Domain;
using System.Security.Cryptography.X509Certificates;

namespace Quartz.Data.Context
{
    public class QuartzDBContext : DbContext
    {
        public QuartzDBContext(DbContextOptions<QuartzDBContext> options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }


    }
}
