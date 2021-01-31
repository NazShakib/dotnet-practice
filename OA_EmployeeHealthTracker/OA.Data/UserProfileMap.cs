using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class UserProfileMap
    {
        public UserProfileMap(EntityTypeBuilder<UserPofile> entityBuilder)
        {
            entityBuilder.HasKey(t=>t.ID);
            entityBuilder.Property(t=> t.FirstName).IsRequired();
            entityBuilder.Property(t => t.LastName).IsRequired();
            entityBuilder.Property(t =>t.HealthRating);
        }
    }
}
