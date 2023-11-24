using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumeRESTfulAPI.Model.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);
            builder.Property(user => user.Name)
                .IsRequired()
                .HasColumnType("VARCHAR(256)");
            builder.Property(user => user.Email)
                .IsRequired()
                .HasColumnType("VARCHAR(256)");
            //builder.HasIndex(user => user.Email)
            //    .IsUnique();
            builder.Property(user => user.Password)
                .IsRequired()
                .HasColumnType("VARCHAR(256)");
            builder.Property(user => user.Address)
                .IsRequired()
                .HasColumnType("VARCHAR(512)");
            builder.Property(user => user.Country)
                .IsRequired()
                .HasColumnType("VARCHAR(512)");
            builder.Property(user => user.City)
                .IsRequired()
                .HasColumnType("VARCHAR(512)");
            builder.Property(user => user.Salary)
                .IsRequired()
                .HasColumnType("DECIMAL(10, 2)");
            builder.Property(user => user.IsDeleted)
                .HasColumnType("BOOLEAN");
            builder.Property(user => user.InsertedDateTime)
                .HasColumnType("DATETIME");
            builder.Property(user => user.UpdatedDateTime)
                .HasColumnType("DATETIME");
            builder.Property(user => user.DeletedDateTime)
                .HasColumnType("DATETIME");
            builder.Property(user => user.CurrentUserId)
                .HasColumnType("INTEGER");
        }
    }
}
