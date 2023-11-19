using RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;
using RepositoryPatternWithUOW.DataService.DTOs.BooksDTO;

namespace RepositoryPatternWithUOW.DataService.DTOs.CategoriesDTOs;

public record CategoryWtihBooksAndAuthorReadDTO
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public int NumberOfBooks { get; init; }
    public IEnumerable<BookWithAuthorReadDTO>? Books { get; init; }
}
