using RepositoryPatternWithUOW.DataService.DTOs.BooksDTO;

namespace RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;

public class AuthorReadWithBook
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public List<BookReadDTO> Books { get; set; } = new List<BookReadDTO>();
}
