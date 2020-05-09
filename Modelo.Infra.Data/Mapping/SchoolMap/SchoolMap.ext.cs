using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping.SchoolMap
{
    public class SchoolMap : SchoolMapBase
    {
        public SchoolMap(EntityTypeBuilder<School> type) : base(type) 
        {

        }

        protected override void CustomConfig(EntityTypeBuilder<School> type)
        {

        }
    }
}
