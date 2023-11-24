using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsumeRESTfulAPI.Model.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Name)
                .IsRequired()
                .HasColumnType("VARCHAR(128)");
            builder.Property(product => product.Price)
                .IsRequired()
                .HasColumnType("DECIMAL(10, 2)");
            builder.Property(product => product.QuantityInStock)
                .IsRequired()
                .HasColumnType("INTEGER");
            builder.Property(product => product.IsDeleted)
                .HasColumnType("BOOLEAN");
            builder.Property(product => product.InsertedDateTime)
                .HasColumnType("DATETIME");
            builder.Property(product => product.UpdatedDateTime)
                .HasColumnType("DATETIME");
            builder.Property(product => product.DeletedDateTime)
                .HasColumnType("DATETIME");
            builder.Property(product => product.CurrentUserId)
                .HasColumnType("INTEGER");
        }
    }
}
