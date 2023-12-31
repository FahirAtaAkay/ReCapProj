﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class FahirakayDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=FahirAkayDb;Integrated Security = true");
        }
        public DbSet<Car> Car { get; set; }
        

    }
}
