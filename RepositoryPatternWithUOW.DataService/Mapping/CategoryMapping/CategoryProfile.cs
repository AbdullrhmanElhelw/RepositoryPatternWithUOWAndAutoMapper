using AutoMapper;
using RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;
using RepositoryPatternWithUOW.DataService.DTOs.CategoriesDTOs;
using RepositoryPatternWithUOW.Entities.Models;

namespace RepositoryPatternWithUOW.DataService.Mapping.CategoryMapping;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        /* CreateMap<Category, CategoryReadDTO>()
             .ForMember(dest => dest.NumberOfBooks,
                            opt => opt.MapFrom(src => src.Books.Count));*/
        CreateMap<Category, CategoryReadDTO>()
             .ForMember(des => des.NumberOfBooks,
             opt => opt.MapFrom(src => src.Books.Count));

        CreateMap<Category, CategoryWithBooksReadDTO>()
            .ForMember(des => des.NumberOfBooks,
            opt => opt.MapFrom(src => src.Books.Count))
            .ForMember(des => des.Books,
            opt => opt.MapFrom(src => src.Books));

        CreateMap<Category, CategoryWtihBooksAndAuthorReadDTO>()
            .ForMember(des => des.NumberOfBooks,
            opt => opt.MapFrom(src => src.Books.Count))
            .ForMember(des => des.Books,
            opt => opt.MapFrom(src => src.Books));

        CreateMap<CategoryCreateDTO, Category>();
        CreateMap<Category, CategoryCreateDTO>();

    }
}
