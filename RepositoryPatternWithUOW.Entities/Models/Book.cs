
namespace RepositoryPatternWithUOW.Entities.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Isbn { get; set; }
    public DateTime? PublishedOn { get; set; }
    public decimal? Price { get; set; }
    public int AuthorId { get; set; }
    public Author? Author { get; set; } 
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
