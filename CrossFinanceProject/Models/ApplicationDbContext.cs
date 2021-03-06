﻿using MySql.Data.Entity;
using System.Data.Entity;

namespace CrossFinanceProject.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(s => s.HasMaxLength(200).HasColumnType("varchar"));

        }

        public ApplicationDbContext()
            : base("WebAppCon")
        {

        }

    }


}