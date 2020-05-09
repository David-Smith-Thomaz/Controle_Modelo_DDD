using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Entities;
using Modelo.Infra.Data.Mapping.UserMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Context
{
    public class DbContextModelo : DbContextMultiTenantcy
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder.Entity<User>());
        }
    }
}
