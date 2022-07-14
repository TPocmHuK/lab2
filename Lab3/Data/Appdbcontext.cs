using lab3.Models;
using Microsoft.EntityFrameworkCore;

public class LanguagesContext : DbContext
{
    public DbSet<LanguagesModel> Languages { get; set; } = null!;
    public DbSet<LanguagesTypeModel> LanguagesType { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            => optionBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=password");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LanguagesModel>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name);
            entity.HasOne(x => x.LanguagesTypeModel).WithMany(x => x.LanguagesModels).HasForeignKey(x => x.TypeId);
        }
        );

        modelBuilder.Entity<LanguagesTypeModel>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Type);
            entity.HasMany(x => x.LanguagesModels).WithOne(x => x.LanguagesTypeModel);

        }
        );
            //.HasOne<LanguagesTypeModel>()
            //.WithMany()
            //.HasForeignKey(d => d.TypeId)
            //.OnDelete(DeleteBehavior.Cascade);
    }
}