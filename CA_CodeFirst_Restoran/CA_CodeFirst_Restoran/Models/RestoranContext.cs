using CA_CodeFirst_Restoran.Models.Entities;
using CA_CodeFirst_Restoran.Models.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CodeFirst_Restoran.Models
{
    public class RestoranContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDb;Database=RestoranDB;Trusted_Connection=True; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>().
                HasOne(x=>x.Employee).
                WithMany(x => x.Orders).
                HasForeignKey(x => x.EmployeeId);



            modelBuilder.Entity<Employee>().HasData(EmpolyeeSeedData.employeeData);

            modelBuilder.Entity<Orders>().HasData(OrdersSeedData.orderSeedData);
            base.OnModelCreating(modelBuilder);
        }
    }
   
}
