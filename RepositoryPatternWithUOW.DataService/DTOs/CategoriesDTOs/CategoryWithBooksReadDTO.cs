using RepositoryPatternWithUOW.DataService.DTOs.BooksDTO;

namespace RepositoryPatternWithUOW.DataService.DTOs.CategoriesDTOs;

public class CategoryWithBooksReadDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } 
    public int NumberOfBooks { get; set; } 
    public IEnumerable<BookReadDTO>? Books { get; set; }
}
