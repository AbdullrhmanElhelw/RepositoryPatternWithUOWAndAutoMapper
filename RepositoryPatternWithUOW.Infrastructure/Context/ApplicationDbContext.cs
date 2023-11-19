using RepositoryPatternWithUOW.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace RepositoryPatternWithUOW.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{ 
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Category> Categories => Set<Category>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var CategoryData = File.ReadAllText("Data/Category.json");
        var AuthorsData = File.ReadAllText("Data/Authors.json");
        var BooksData = File.ReadAllText("Data/Books.json");
        var Categories = JsonSerializer.Deserialize<List<Category>>(CategoryData);
        var Authors = JsonSerializer.Deserialize<List<Author>>(AuthorsData);
        var Books = JsonSerializer.Deserialize<List<Book>>(BooksData);

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).HasMaxLength(50).IsRequired();
            entity.Property(e => e.Surname).HasMaxLength(50);
            entity.Property(e => e.Bio).HasMaxLength(200);

            entity
            .HasMany(e => e.Books)
            .WithOne(e => e.Author)
            .HasForeignKey(e => e.AuthorId)
            .HasConstraintName("FK_Author_Book");

            entity.HasData(Authors);

        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).HasMaxLength(50).IsRequired();
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Isbn).HasMaxLength(50);
            entity.Property(e => e.PublishedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18,2)");

            entity.HasData(Books);

        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e=>e.Name).HasMaxLength(50).IsRequired();
            entity.Property(e=>e.Description).HasMaxLength(200);
            
            entity
            .HasMany(e => e.Books)
            .WithOne(e => e.Category)
            .HasForeignKey(e => e.CategoryId)
            .HasConstraintName("FK_Category_Book");

            entity.HasData(Categories); 
        });



        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

}
