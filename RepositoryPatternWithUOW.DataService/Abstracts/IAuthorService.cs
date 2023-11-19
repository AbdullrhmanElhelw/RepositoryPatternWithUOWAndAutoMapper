using RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;

namespace RepositoryPatternWithUOW.DataService.Abstracts;

public interface IAuthorService
{
    AuthorReadDTO? GetAuthor(int id);
    AuthorReadWithBook? GetAuthorWithBooks(int id);
    IEnumerable<AuthorReadDTO> GetAuthors();
    AuthorReadDTO? FindAuthor(Func<AuthorReadDTO, bool> critria);
    AuthorCreateDTO CreateAuthor(AuthorCreateDTO authorCreateDTO);
    void DeleteAuthor(int id);
    AuthorUpdateDTO UpdateAuthor(AuthorUpdateDTO authorUpdateDTO);
    AuthorReadWithBook? FindAuthorWithBooks(Func<AuthorReadWithBook, bool> critria);
}
