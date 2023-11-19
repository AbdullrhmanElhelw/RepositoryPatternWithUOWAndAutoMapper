using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithUOW.Entities.Models;
using RepositoryPatternWithUOW.Infrastructure.Abstracts;
using RepositoryPatternWithUOW.Infrastructure.Context;
using RepositoryPatternWithUOW.Infrastructure.InfrastructreBases;

namespace RepositoryPatternWithUOW.Infrastructure.Implementations;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Category> FindCategories(Func<Category, bool> predicate) =>
         _dbContext.Categories.Where(predicate).ToList();
    

    public Category? FindCategory(Func<Category, bool> predicate) => 
        _dbContext.Categories.FirstOrDefault(predicate);

    public IEnumerable<Category> GetCategoriesWithBooks() =>
        _dbContext.Categories.Include(c => c.Books).ToList();

    public IEnumerable<Category> GetCategoriesWithBooksAndAuthors() =>
        _dbContext.Categories
            .Include(c => c.Books)
            .ThenInclude(b => b.Author)
            .ToList();
  
    public Category? GetCategoryWithBooks(int id) =>
        _dbContext.Categories.Include(c => c.Books).FirstOrDefault(c => c.Id == id);

    public Category? GetCategoryWithBooksAndAuthors(int id) =>
        _dbContext.Categories
        .Include(c=>c.Books)
        .ThenInclude(b=>b.Author)
        .FirstOrDefault(c => c.Id == id);
}

