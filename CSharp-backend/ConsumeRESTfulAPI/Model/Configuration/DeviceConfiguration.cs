using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumeRESTfulAPI.Model.Configuration
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasKey(device => device.Id);
            builder.Property(device => device.Name)
                .IsRequired()
                .HasColumnType("VARCHAR(128)");
            builder.Property(device => device.UserId)
                .IsRequired()
                .HasColumnType("INTEGER");
            builder.Property(device => device.Price)
                .IsRequired()
                .HasColumnType("DECIMAL(10, 2)");
            builder.Property(device => device.IsDeleted)
                .HasColumnType("BOOLEAN");
            builder.Property(device => device.InsertedDateTime)
                .HasColumnType("DATETIME");
            builder.Property(device => device.UpdatedDateTime)
                .HasColumnType("DATETIME");
            builder.Property(device => device.DeletedDateTime)
                .HasColumnType("DATETIME");
            builder.Property(device => device.CurrentUserId)
                .HasColumnType("INTEGER");
        }
    }
}
