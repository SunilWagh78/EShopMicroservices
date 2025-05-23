﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ordering.Domain.Models;
using Ordering.Domain.ValueObjects;

namespace Ordering.Infrastructure.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasConversion(
                customerId => customerId.Value,
                dbId => CustomerId.Of(dbId) // Assuming you have a method to convert from string to CustomerId
            );
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Email).HasMaxLength(100);
            builder.HasIndex(c => c.Email).IsUnique();
        }
    }
}
