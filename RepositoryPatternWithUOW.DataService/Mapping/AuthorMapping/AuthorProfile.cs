using AutoMapper;
using RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;
using RepositoryPatternWithUOW.Entities.Models;

namespace RepositoryPatternWithUOW.DataService.Mapping.AuthorMapping;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<Author, AuthorReadDTO>()
          .ForMember(des => des.FullName, opt => opt.MapFrom(src => src.Name + " " + src.Surname));

        CreateMap<Author, AuthorReadWithBook>()
            .ForMember(des => des.Books, opt => opt.MapFrom(ser => ser.Books))
            .ForMember(des => des.FullName, opt => opt.MapFrom(ser => ser.Name + " " + ser.Surname));

        CreateMap<AuthorCreateDTO, Author>();

        CreateMap<AuthorUpdateDTO, Author>();

        CreateMap<Author, AuthorUpdateDTO>();
    }
}
