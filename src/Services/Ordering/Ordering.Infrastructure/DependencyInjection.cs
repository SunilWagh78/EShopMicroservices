using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Database");
            // Add your infrastructure services here
            // services.AddDbContext<ApplicationDbContext>(options =>
            // options.UseSqlServer(connectionString));
            // services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            return services;
        }
    }
}
