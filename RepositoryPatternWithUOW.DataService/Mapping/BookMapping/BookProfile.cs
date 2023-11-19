using AutoMapper;
using RepositoryPatternWithUOW.DataService.DTOs.BooksDTO;
using RepositoryPatternWithUOW.Entities.Models;

namespace RepositoryPatternWithUOW.DataService.Mapping.BookMapping;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<Book, BookReadDTO>();
        CreateMap<BookCreateDTO, Book>();
        CreateMap<Book, BookCreateDTO>();
        CreateMap<Book, BookWithAuthorReadDTO>()
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name + " " + src.Author.Surname));
        CreateMap<BookUpdateDTO, Book>();
        CreateMap<Book, BookUpdateDTO>();
    }
}
