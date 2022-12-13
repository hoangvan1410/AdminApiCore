using API.Infras.Services.UserAdmin;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Infras
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddTransient<IUserAdminServices, UserAdminServices>();

            return services;
        }
    }
}