using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(t => t.ID);
            entityBuilder.Property(t => t.FirstName).IsRequired();
            entityBuilder.Property(t => t.LastName).IsRequired();
            entityBuilder.Property(t => t.UserType).IsRequired();
            entityBuilder.Property(t => t.Email).IsRequired();
            entityBuilder.Property(t => t.Password).IsRequired();
        }
    }
}
