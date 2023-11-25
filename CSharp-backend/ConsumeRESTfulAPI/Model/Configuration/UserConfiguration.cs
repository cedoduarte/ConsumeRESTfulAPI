using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumeRESTfulAPI.Model.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(user => user.Name)
                .IsRequired(true)
                .HasColumnType("VARCHAR(256)");
            builder.Property(user => user.Email)
                .IsRequired(true)
                .HasColumnType("VARCHAR(256)");
            builder.Property(user => user.Password)
                .IsRequired(true)
                .HasColumnType("VARCHAR(256)");
            builder.Property(user => user.Birthdate)
                .IsRequired(true)
                .HasColumnType("DATETIME(6)");
            builder.Property(user => user.Address)
                .IsRequired(true)
                .HasColumnType("VARCHAR(512)");
            builder.Property(user => user.Country)
                .IsRequired(true)
                .HasColumnType("VARCHAR(512)");
            builder.Property(user => user.City)
                .IsRequired(true)
                .HasColumnType("VARCHAR(512)");
            builder.Property(user => user.Salary)
                .IsRequired(true)
                .HasColumnType("DECIMAL(10, 2)");
            builder.Property(user => user.IsDeleted)
                //.IsRequired(false)
                .HasColumnType("BOOLEAN");
            builder.Property(user => user.InsertedDateTime)
                .IsRequired(false)
                .HasColumnType("DATETIME(6)");
            builder.Property(user => user.UpdatedDateTime)
                .IsRequired(false)
                .HasColumnType("DATETIME(6)");
            builder.Property(user => user.DeletedDateTime)
                .IsRequired(false)
                .HasColumnType("DATETIME(6)");
            builder.Property(user => user.CurrentUserId)
                //.IsRequired(false)
                .HasColumnType("INTEGER");
        }
    }
}
