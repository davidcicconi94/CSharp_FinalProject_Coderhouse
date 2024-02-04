using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Coder.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace Coder.DataAccess.Persistance
{
    public static class ServiceExtension
    {
        const string CONNECTION_STRING = "Data Source=.\\SQLExpress;Initial Catalog=coderhouse;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString(CONNECTION_STRING);

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
