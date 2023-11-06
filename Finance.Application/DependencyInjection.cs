using AutoMapper;
using Finance.Application.Features.Commands.Category.CreateCategory;
using Finance.Application.Mapping;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Finance.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration confiq)
        {
            services.AddScoped(typeof(IRequestHandler<CreateCategoryCommand>), typeof(CreateCategoryCommandHandler));

            //services.AddScoped(typeof(IRequestHandler<GetAllProductsQuery, List<ProductDto>>),
            //    typeof(GetAllProductsQueryHandler));

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new GeneralMapping());
            });

            services.AddSingleton(config.CreateMapper());

            return services;
        }
    }
}
