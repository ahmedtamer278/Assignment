using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Context
{
    class CompanyDbContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; } // table => Employees
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; Database = ITI ; Trusted_Connection= True; Trust Server Certificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .ToTable("Employees")
                .HasKey(e => e.EmpId);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .HasColumnType("varchar")
                .HasMaxLength(30);


        }
    }
}
