using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Context
{
    public class DbContextMultiTenantcy
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            var connectionString = ConfigureConnectionString();

            if (connectionString != null || connectionString != "") 
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        private string ConfigureConnectionString() 
        {
            string source = "";
            string catalog = "";
            string user = "";
            string password = "";

            return $"Data Source={source}; Initial Catalog={catalog};user id={user};password={password};Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;MultipleActiveResultSets=True";
        }
    }
}
