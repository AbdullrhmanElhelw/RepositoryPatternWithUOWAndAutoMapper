
namespace RepositoryPatternWithUOW.DataService.DTOs.BooksDTO;

public class BookReadDTO
{
    private string _title = string.Empty;
    public int Id { get; set; }
    public string Title
    {
        get => _title;
        set
        {
            if (value != null)
                _title = value;
            if(value == "")
                _title = "No Title";
        }
    }
}
