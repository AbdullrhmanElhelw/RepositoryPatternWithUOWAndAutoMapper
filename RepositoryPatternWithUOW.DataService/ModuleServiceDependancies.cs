using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RepositoryPatternWithUOW.DataService.Abstracts;
using RepositoryPatternWithUOW.DataService.Implementation;
using RepositoryPatternWithUOW.DataService.Mapping.AuthorMapping;
using RepositoryPatternWithUOW.DataService.Mapping.BookMapping;
using RepositoryPatternWithUOW.DataService.Mapping.CategoryMapping;

namespace RepositoryPatternWithUOW.DataService;

public static class ModuleServiceDependancies
{
    public static IServiceCollection AddServiceDependancies(this IServiceCollection services)
    {
        services.AddTransient<IAuthorService, AuthorService>();
        services.AddTransient<IBookService, BookService>();
        services.AddTransient<ICategoryService, CategoryService>();
        return services;
    }

    public static IServiceCollection AddAutoMapper(this IServiceCollection services)
    {
        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new AuthorProfile());
            mc.AddProfile(new BookProfile());
            mc.AddProfile(new CategoryProfile());
        });

        IMapper mapper = mappingConfig.CreateMapper();
        services.AddSingleton(mapper); 
        return services;
    }


}
