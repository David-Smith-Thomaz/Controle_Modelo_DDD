using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Context
{
    public class DbContextMultiTenantcy : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigureConnectionString();

            if (connectionString != null || connectionString != "")
            {
                optionsBuilder.UseSqlServer(connectionString);
                base.OnConfiguring(optionsBuilder);
            }
            else
            {
                base.OnConfiguring(optionsBuilder);
            }
        }

        public string ConfigureConnectionString() 
        {
            string source = "(localdb)" + "'\'" + "mssqllocaldb";
            string catalog = "Controle_Modelo";
            string user = null;
            string password = null;

            return $"Data Source={source}; Initial Catalog={catalog};user id={user};password={password};Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;MultipleActiveResultSets=True";
        }
    }
}