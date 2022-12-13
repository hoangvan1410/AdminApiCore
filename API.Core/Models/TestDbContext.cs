using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace API.Core.Models;

public partial class TestDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public TestDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestTbl> TestTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConnectionStrings"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TestTbl>(entity =>
        {
            entity.HasKey(e => e.Column1);

            entity.ToTable("TestTBL");

            entity.Property(e => e.Column1)
                .ValueGeneratedNever()
                .HasColumnName("column_1");
            entity.Property(e => e.Column2).HasColumnName("column_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
