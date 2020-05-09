using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping.ClassSchoolMap
{
    public class ClassSchoolMap : ClassSchoolMapBase
    {
        public ClassSchoolMap(EntityTypeBuilder<ClassSchool> type) : base(type) 
        {

        }

        protected override void CustomConfig(EntityTypeBuilder<ClassSchool> type)
        {

        }
    }
}
