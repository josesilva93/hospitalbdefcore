using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testefcore.models;

namespace testefcore.DAO
{
    public class TestContext : DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Medicamento> Medicamento { get; set; }

        public DbSet<Prueba> Prueba { get; set; }

        public string DbPath { get; }

        public TestContext()
        {

        }

        // The following configures EF to create a Sql database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=DESKTOP-B2SJJGE\\SQLEXPRESS;Database=test;Trusted_Connection=True");
    }
}
