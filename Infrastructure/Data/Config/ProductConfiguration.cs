using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Um).IsRequired();
            builder.Property(p => p.Price).HasColumnType("decimal(10,2)");

            builder.HasOne(b => b.ProductCategory)
                   .WithMany()
                   .HasForeignKey(p => p.ProductCategoryId);
            builder.HasOne(t => t.ProductCompany)
                   .WithMany()
                   .HasForeignKey(p => p.ProductCompanyId);
        }
    }
}