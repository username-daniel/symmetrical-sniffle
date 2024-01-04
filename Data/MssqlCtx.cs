using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DocGems.Data;

public class MssqlCtx : IdentityDbContext<User>

{
    //public DbSet<WeatherForecast> WeatherForecast { get; set; }
    public DbSet<Document> Document { get; set; }
    public DbSet<UserDocument> UserDocuments { get; set; }
    public DbSet<User> User { get; set; }

    
    public MssqlCtx(DbContextOptions<MssqlCtx> options) : base(options)
    {
    }
    
    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserDocument>()
            .HasKey(ud => new { ud.UserId, ud.DocumentId });

        modelBuilder.Entity<UserDocument>()
            .HasOne(ud => ud.User)
            .WithMany(u => u.UserDocuments)
            .HasForeignKey(ud => ud.UserId);

        modelBuilder.Entity<UserDocument>()
            .HasOne(ud => ud.Document)
            .WithMany(d => d.UserDocuments)
            .HasForeignKey(ud => ud.DocumentId);

        //modelBuilder.Entity<IdentityUserLogin<string>>()
          //  .HasKey(l => new { l.LoginProvider, l.ProviderKey });
    }*/

    
}