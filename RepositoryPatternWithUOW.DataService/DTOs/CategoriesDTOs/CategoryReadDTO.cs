namespace RepositoryPatternWithUOW.DataService.DTOs.CategoriesDTOs;

public class CategoryReadDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public int NumberOfBooks { get; set; }
}
