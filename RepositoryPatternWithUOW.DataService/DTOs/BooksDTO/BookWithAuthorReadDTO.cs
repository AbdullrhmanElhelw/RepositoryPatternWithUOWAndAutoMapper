
using RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;

namespace RepositoryPatternWithUOW.DataService.DTOs.BooksDTO;

public class BookWithAuthorReadDTO
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Author { get; set; }
}
