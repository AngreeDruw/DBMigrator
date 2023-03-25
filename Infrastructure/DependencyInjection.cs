using ApplicationLayer.DbContext;
using Infrastructure.EntityDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureDI(this IServiceCollection services, ConnectionStringSettingsCollection connactionStrings)
        {
            #region EntityDbContext
            string? connection = connactionStrings["DefaultConnection"].ConnectionString;
            services.AddDbContext<IEntityDbContext, EntityContext>(options =>
            options.UseSqlite(connection),
                ServiceLifetime.Scoped);
            #endregion
        }
    }
}
