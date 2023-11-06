using Finance.Domain.IRepository;
using Finance.Infastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Finance.Infastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration confiq)
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();
           
            return services;
        }
    }
}
