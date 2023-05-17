using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Identity_Live.Areas.Identity.Data;

namespace MVC_Identity_Live.Data;

public class MVC_Identity_LiveContext : IdentityDbContext<IdentityUser>
{
    public MVC_Identity_LiveContext(DbContextOptions<MVC_Identity_LiveContext> options)
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
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(20);
        builder.Property(u => u.LastName).HasMaxLength(20);
        builder.Property(u => u.City).HasMaxLength(13);
        builder.Property(u => u.FaxNumber).HasMaxLength(13);
    }
}