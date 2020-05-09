using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;

namespace Modelo.Infra.Data.Mapping
{
    public abstract class SchoolMapBase
    {
        protected abstract void CustomConfig(EntityTypeBuilder<School> type);

        public SchoolMapBase(EntityTypeBuilder<School> type)
        {
            type.ToTable("School");
            type.Property(_ => _.SchoolId).HasColumnName("SchoolId");

            type.Property(_ => _.Name).HasColumnName("Name").HasColumnType("varchar(100)");
            type.Property(_ => _.Tell).HasColumnName("Tell").HasColumnType("varchar(100)");
            type.Property(_ => _.Address).HasColumnName("Address").HasColumnType("varchar(100)");
            //type.Property(_ => _.UserCreateId).HasColumnName("UserCreateId");
            //type.Property(_ => _.UserCreateDate).HasColumnName("UserCreateDate");
            //type.Property(_ => _.UserAlterId).HasColumnName("UserAlterId");
            //type.Property(_ => _.UserAlterDate).HasColumnName("UserAlterDate");

            type.HasKey(_ => new { _.SchoolId });

            CustomConfig(type);
        }
    }
}
