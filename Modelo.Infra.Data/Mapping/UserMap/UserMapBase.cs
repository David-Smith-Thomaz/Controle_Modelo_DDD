using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;

namespace Modelo.Infra.Data.Mapping
{
    public abstract class UserMapBase
    {
        protected abstract void CustomConfig(EntityTypeBuilder<User> type);

        public UserMapBase(EntityTypeBuilder<User> type)
        {
            type.ToTable("User");
            type.Property(_ => _.UserId).HasColumnName("UserId");

            type.Property(_ => _.CompleteName).HasColumnName("CompleteName").HasColumnType("varchar(100)");
            type.Property(_ => _.DocumentNumber).HasColumnName("DocumentNumber").HasColumnType("varchar(100)");
            //type.Property(_ => _.UserCreateId).HasColumnName("UserCreateId");
            //type.Property(_ => _.UserCreateDate).HasColumnName("UserCreateDate");
            //type.Property(_ => _.UserAlterId).HasColumnName("UserAlterId");
            //type.Property(_ => _.UserAlterDate).HasColumnName("UserAlterDate");

            type.HasKey(_ => new { _.UserId });

            CustomConfig(type);
        }
    }
}
