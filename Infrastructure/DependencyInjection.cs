using ApplicationLayer.DbContext;
using Infrastructure.EntityDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddApplicationDI(this IServiceCollection services, IConfiguration configuration)
        {
            #region EntityDbContext
            string? connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<IEntityDbContext, EntityContext>(options =>
            options.UseSqlite(connection),
                ServiceLifetime.Scoped);
            #endregion
        }
    }
}
