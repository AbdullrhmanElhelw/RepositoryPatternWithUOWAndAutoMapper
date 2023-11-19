using Microsoft.Extensions.DependencyInjection;
using RepositoryPatternWithUOW.Infrastructure.UnitOfWork;


namespace RepositoryPatternWithUOW.Infrastructure;

public static class ModuleInfrastructureDependancies
{
    public static IServiceCollection AddInfrastructureDependancies(this IServiceCollection services)
    {
        services.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>();
        return services;
    }
}
