using Medline.Recall.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Medline.Recall.Core.Entities;
using Medline.Recall.Core.SharedKernel;
using System;

namespace Medline.Recall.Infrastructure.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
            : base(options)
        {
        }
      
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Shailesh",
                LastName = "Rathi",
                Email = "shaileshrathi.rathi@gmail.com",
                DateOfBirth = new DateTime(1981, 04, 25),
                PhoneNumber = "999-888-7777"

            }, new Employee
            {
                EmployeeId = 2,
                FirstName = "Rajeev",
                LastName = "Jain",
                Email = "rnjain@gmail.com",
                DateOfBirth = new DateTime(1983, 07, 13),
                PhoneNumber = "111-222-3333"
            });
        }
    }
}
