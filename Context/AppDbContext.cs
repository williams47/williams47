using JoiaShop.ProdutoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JoiaShop.ProdutoApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }

    //Fluent API
    protected override void OnModelCreating(ModelBuilder modelb)
    {
        //categoria   modelb é ModelBuilder e c. é CategoriaId

        modelb.Entity<Categoria>().HasKey(c => c.CategoriaId);

        modelb.Entity<Categoria>().
            Property(c => c.Nome).
            HasMaxLength(100).
            IsRequired();

        //Produto
        modelb.Entity<Produto>().
           Property(c => c.Nome).
           HasMaxLength(100).
           IsRequired();

        modelb.Entity<Produto>().
          Property(c => c.Preço).
          HasPrecision(12, 2);

        modelb.Entity<Produto>().
            Property(c => c.Descrição).
            HasMaxLength(255).
            IsRequired();

        modelb.Entity<Produto>().
           Property(c => c.ImageURL).
           HasMaxLength(255).
           IsRequired();

        modelb.Entity<Categoria>()
           .HasMany(g => g.Produtos)
            .WithOne(c => c.Categoria)
             .IsRequired()
              .OnDelete(DeleteBehavior.Cascade);


        modelb.Entity<Categoria>().HasData(
        new Categoria
        {
            CategoriaId = 1,
            Nome = "Joias",
        },
        new Categoria
        {
            CategoriaId = 2,
            Nome = "Bijuterias",
        }
        );

    }
}
