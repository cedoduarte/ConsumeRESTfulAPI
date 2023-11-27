using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumeRESTfulAPI.Model.Configuration
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.Property(device => device.Name)
                .IsRequired(true)
                .HasColumnType("VARCHAR(128)");
            builder.Property(device => device.UserId)
                .IsRequired(true)
                .HasColumnType("INTEGER");
            builder.Property(device => device.Price)
                .IsRequired(true)
                .HasColumnType("DECIMAL(10, 2)");
            builder.Property(device => device.IsDeleted)
                //.IsRequired(false)
                .HasColumnType("BOOLEAN");
            builder.Property(device => device.InsertedDateTime)
                .IsRequired(false)
                .HasColumnType("DATETIME(6)");
            builder.Property(device => device.UpdatedDateTime)
                .IsRequired(false)
                .HasColumnType("DATETIME(6)");
            builder.Property(device => device.DeletedDateTime)
                .IsRequired(false)
                .HasColumnType("DATETIME(6)");
            builder.Property(device => device.CurrentUserId)
                //.IsRequired(false)
                .HasColumnType("INTEGER");
        }
    }
}
