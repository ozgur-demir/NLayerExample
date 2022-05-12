using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                Name = "Kalem 1",
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Price = 300,
                Stock = 20,
                Name = "Kalem 2",
                CreatedDate = DateTime.Now
            },
             new Product
             {
                 Id = 3,
                 CategoryId = 1,
                 Price = 500,
                 Stock = 20,
                 Name = "Kalem 3",
                 CreatedDate = DateTime.Now
             },
             new Product
             {
                 Id = 4,
                 CategoryId = 2,
                 Price = 1000,
                 Stock = 25,
                 Name = "Kitap 1",
                 CreatedDate = DateTime.Now
             },
             new Product
             {
                 Id = 5,
                 CategoryId = 2,
                 Price = 1500,
                 Stock = 25,
                 Name = "Kitap 2",
                 CreatedDate = DateTime.Now
             });


        }
    }
}
