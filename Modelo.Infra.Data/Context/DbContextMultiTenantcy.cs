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
            var result = @"Data Source=(localdb)\mssqllocaldb; Initial Catalog = Controle_Modelo; Integrated Security = True";
            return result;
        }
    }
}