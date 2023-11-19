
namespace RepositoryPatternWithUOW.Entities.Models;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Surname { get; set; }
    public string? Bio { get; set; }
    public ICollection<Book> Books { get; set; } = new HashSet<Book>();
}
