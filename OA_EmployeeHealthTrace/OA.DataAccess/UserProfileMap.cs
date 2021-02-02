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
            entityBuilder.Property(t => t.UserID).IsRequired();
            entityBuilder.Property(t =>t.HealthRating).IsRequired();
            entityBuilder.Property(t => t.Comment);
            entityBuilder.HasOne(t => t.User).WithMany(u => u.UserPofiles).HasForeignKey(u=>u.UserID);
        }
    }
}
