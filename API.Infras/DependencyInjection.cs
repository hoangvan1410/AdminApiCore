using API.Core.Models;
using API.Infras.Services.Product;
using API.Infras.Services.UserAdmin;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Infras
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddSqlServer<TestDbContext>(Configuration.GetConnectionString("ConnectionStrings"));

            services.AddTransient<IUserAdminServices, UserAdminServices>();
            services.AddTransient<IProductServices, ProductServices>();
            return services;
        }
    }
}