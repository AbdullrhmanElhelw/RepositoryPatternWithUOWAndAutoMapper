using RepositoryPatternWithUOW.DataService.DTOs.CategoriesDTOs;

namespace RepositoryPatternWithUOW.DataService.Abstracts;

public interface ICategoryService
{
    CategoryReadDTO? GetCategory(int id);
    CategoryWithBooksReadDTO GetCategoryWithBooks(int id);
    CategoryWtihBooksAndAuthorReadDTO GetCategoryWtihBooksAndAuthor(int id);
    IEnumerable<CategoryReadDTO> GetCategories();
    IEnumerable<CategoryWithBooksReadDTO> GetCategoriesWithBooks();
    IEnumerable<CategoryWtihBooksAndAuthorReadDTO> GetCategoriesWithBooksAndAuthor();
    IEnumerable<CategoryReadDTO> FindCategories(Func<CategoryReadDTO, bool> predicate);
    IEnumerable<CategoryWtihBooksAndAuthorReadDTO> FindCategories(Func<CategoryWtihBooksAndAuthorReadDTO, bool> predicate);
    CategoryReadDTO FindCategory(Func<CategoryReadDTO, bool> predicate);
    CategoryCreateDTO CreateCategory(CategoryCreateDTO categoryCreateDTO);

}
