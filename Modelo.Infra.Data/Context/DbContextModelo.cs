using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modelo.Domain.Entities;
using Modelo.Infra.Data.Mapping.ClassSchoolMap;
using Modelo.Infra.Data.Mapping.SchoolMap;
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
            new ClassSchoolMap(modelBuilder.Entity<ClassSchool>());
            new SchoolMap(modelBuilder.Entity<School>());
        }
    }
}
