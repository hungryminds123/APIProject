﻿using Microsoft.EntityFrameworkCore;

namespace Domain
{

    /*
     * 1. Employee
     * 2. Customer
     * 3. Department
     * 
     */


    public class SampleDatabaseDbContext : DbContext
    {
        public SampleDatabaseDbContext(DbContextOptions<SampleDatabaseDbContext> options): base(options) 
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }



        public DbSet<Employee> Employees { get; set;}

        public DbSet<Department> Departments { get; set;}

    }
}
