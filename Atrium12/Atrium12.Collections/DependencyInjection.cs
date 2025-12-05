using Atrium12.Collections.Application.Interfaces;
using Atrium12.Collections.Application.Services;
using Atrium12.Collections.Infrastructure.Postgres;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Atrium12.Collections
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);
            services.AddScoped<IItemsService, ItemsService>();
            services.AddScoped<IItemRepository, ItemRepository>();

            return services;
        }
    }
}
