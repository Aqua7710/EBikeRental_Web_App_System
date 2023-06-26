using EBikeRental_Web_App_System.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EBikeRental_Web_App_System.Models;

namespace EBikeRental_Web_App_System.Areas.Identity.Data;

public class IdentityContext : IdentityDbContext<EBikeRental_Web_App_SystemUser>
{
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }

    public DbSet<EBikeRental_Web_App_System.Models.Bike> Bike { get; set; } = default!;

    public DbSet<EBikeRental_Web_App_System.Models.Customer> Customer { get; set; } = default!;

    public DbSet<EBikeRental_Web_App_System.Models.Payment> Payment { get; set; } = default!;

    public DbSet<EBikeRental_Web_App_System.Models.PaymentsType> PaymentsType { get; set; } = default!;

    public DbSet<EBikeRental_Web_App_System.Models.Rental> Rental { get; set; } = default!;

    public DbSet<EBikeRental_Web_App_System.Models.Staff> Staff { get; set; } = default!;
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<EBikeRental_Web_App_SystemUser>
{
    public void Configure(EntityTypeBuilder<EBikeRental_Web_App_SystemUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}
