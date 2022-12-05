using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backendcountry.Models;

public partial class CountrydbsContext : DbContext
{
    public CountrydbsContext()
    {
    }

    public CountrydbsContext(DbContextOptions<CountrydbsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Countrystabless> Countrystablesses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
    
 }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Countrystabless>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__countrys__7E95F50D46DDFAC3");

            entity.ToTable("countrystabless");

            entity.Property(e => e.CountryId).HasColumnName("country_Id");
            entity.Property(e => e.CaptitalOfcountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("captital_ofcountry");
            entity.Property(e => e.CountrtyRegion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("countrty_region");
            entity.Property(e => e.CountryCurrency)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country_currency");
            entity.Property(e => e.CountryFlag).HasColumnName("country_flag");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country_name");
            entity.Property(e => e.CountryPopulation).HasColumnName("country_population");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
