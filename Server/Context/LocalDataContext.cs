using ISIvanti.Server.Models;
using ISIvanti.Server.Models.LocalModels;
using Microsoft.EntityFrameworkCore;

namespace ISIvanti.Server.Context;

public class LocalDataContext : DbContext
{
    public LocalDataContext(DbContextOptions<LocalDataContext> options) : base(options)
    {
    }

    public DbSet<EFJob> Jobs { get; set; }
    public DbSet<EFStatistic> Statistics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EFJob>().ToTable("EFJobs");
        modelBuilder.Entity<EFStatistic>().ToTable("EFStatistics");

        base.OnModelCreating(modelBuilder);
    }
}
