
namespace RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;

public class AuthorUpdateDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string SurName { get; set; } = string.Empty;
}
