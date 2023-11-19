﻿

namespace RepositoryPatternWithUOW.Entities.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public ICollection<Book> Books { get; set; } = new HashSet<Book>();
}
