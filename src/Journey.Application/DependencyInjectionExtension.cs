using Journey.Application.UseCase.Books.Register;
using Microsoft.Extensions.DependencyInjection;

namespace Journey.Application;

public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddUseCase(services);
    }

    private static void AddUseCase(IServiceCollection services)
    {
        services.AddScoped<IRegisterTripUseCase, RegisterTripUseCase>();
    } 
}