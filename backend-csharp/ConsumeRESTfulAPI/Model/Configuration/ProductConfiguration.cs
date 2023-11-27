using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumeRESTfulAPI.Model.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(product => product.Name)
                .IsRequired(true)
                .HasColumnType("VARCHAR(128)");
            builder.Property(product => product.Price)
                .IsRequired(true)
                .HasColumnType("DECIMAL(10, 2)");
            builder.Property(product => product.QuantityInStock)
                .IsRequired(true)
                .HasColumnType("INTEGER");
            builder.Property(product => product.IsDeleted)
                //.IsRequired(false)
                .HasColumnType("BOOLEAN");
            builder.Property(product => product.InsertedDateTime)
                .IsRequired(false)
                .HasColumnType("DATETIME(6)");
            builder.Property(product => product.UpdatedDateTime)
                .IsRequired(false)
                .HasColumnType("DATETIME(6)");
            builder.Property(product => product.DeletedDateTime)
                .IsRequired(false)
                .HasColumnType("DATETIME(6)");
            builder.Property(product => product.CurrentUserId)
                //.IsRequired(false)
                .HasColumnType("INTEGER");
        }
    }
}
