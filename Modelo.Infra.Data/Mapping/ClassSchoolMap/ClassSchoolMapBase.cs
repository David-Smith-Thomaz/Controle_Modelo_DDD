using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;

namespace Modelo.Infra.Data.Mapping
{
    public abstract class ClassSchoolMapBase
    {
        protected abstract void CustomConfig(EntityTypeBuilder<ClassSchool> type);

        public ClassSchoolMapBase(EntityTypeBuilder<ClassSchool> type)
        {
            type.ToTable("ClassSchool");
            type.Property(_ => _.ClassSchoolId).HasColumnName("ClassSchoolId");

            type.Property(_ => _.SchoolId).HasColumnName("SchoolId");
            type.Property(_ => _.Name).HasColumnName("Name").HasColumnType("varchar(100)");
            type.Property(_ => _.Email).HasColumnName("Email").HasColumnType("varchar(100)");
            //type.Property(_ => _.UserCreateId).HasColumnName("UserCreateId");
            //type.Property(_ => _.UserCreateDate).HasColumnName("UserCreateDate");
            //type.Property(_ => _.UserAlterId).HasColumnName("UserAlterId");
            //type.Property(_ => _.UserAlterDate).HasColumnName("UserAlterDate");

            type.HasKey(_ => new { _.SchoolId });

            CustomConfig(type);
        }
    }
}
