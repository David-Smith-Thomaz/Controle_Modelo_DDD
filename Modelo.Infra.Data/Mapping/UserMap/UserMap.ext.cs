using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping.UserMap
{
    public class UserMap : UserMapBase
    {
        public UserMap(EntityTypeBuilder<User> type) : base(type) 
        {

        }

        protected override void CustomConfig(EntityTypeBuilder<User> type)
        {

        }
    }
}
