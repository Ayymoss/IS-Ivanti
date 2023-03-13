using ISIvanti.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace IvantiToAdmins.Context;

public class LocalDataContext : DbContext
{
    public LocalDataContext(DbContextOptions<LocalDataContext> options) : base(options)
    {
    }

    public DbSet<EFJob> Jobs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EFJob>().ToTable("EFJobs");

        base.OnModelCreating(modelBuilder);
    }
}
