using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //services.AddAutoMapper(typeof(DependencyInjection).Assembly);
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
            //services.AddScoped<IOrderRepository, OrderRepository>();
            //services.AddScoped<IValidator<Order>, OrderValidator>();
            return services;
        }
    }
}
