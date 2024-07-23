using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

                new Product { Id = 1, ProductName = "Iphone 15 Pro", ProductPrice = 71000, CategoryId = 1 },
                new Product { Id = 2, ProductName = "Iphone 15", ProductPrice = 52000, CategoryId = 1 },
                new Product { Id = 3, ProductName = "Samsung Galaxy Z", ProductPrice = 89000, CategoryId = 1 }
            );
        }
    }
}
