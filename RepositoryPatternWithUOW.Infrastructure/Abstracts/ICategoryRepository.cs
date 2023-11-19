using RepositoryPatternWithUOW.Entities.Models;
using RepositoryPatternWithUOW.Infrastructure.InfrastructreBases;

namespace RepositoryPatternWithUOW.Infrastructure.Abstracts;

public interface ICategoryRepository : IBaseRepository<Category>
{
    Category? GetCategoryWithBooks(int id);
    Category? GetCategoryWithBooksAndAuthors(int id);
    Category? FindCategory(Func<Category, bool> predicate);
    IEnumerable<Category> GetCategoriesWithBooks();
    IEnumerable<Category> GetCategoriesWithBooksAndAuthors();
    IEnumerable<Category> FindCategories(Func<Category, bool> predicate);
}
