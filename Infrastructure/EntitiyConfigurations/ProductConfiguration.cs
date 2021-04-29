﻿using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntitiyConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Title)
                   .HasColumnType("varchar")
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.CreatedAt)
                   .HasColumnType("date")
                   .IsRequired();

            //builder.Property(x => x.CreatedAtFormatted)
            //       .HasColumnType("varchar")
            //       .IsRequired()
            //       .HasMaxLength(200);

            builder.Property(x => x.Image)
                    .HasColumnType("varchar")
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.Amount)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(x => x.Price)
                   .HasColumnType("int")
                   .IsRequired();

            builder.Property(x => x.PriceFormatted)
                   .HasColumnType("varchar")
                   .IsRequired()
                   .HasMaxLength(200);

            //builder.Property(x => x.Description)
            //       .HasColumnType("varchar")
            //       .IsRequired()
            //       .HasMaxLength(400);

            builder.ToTable("Products");
        }
    }
}
