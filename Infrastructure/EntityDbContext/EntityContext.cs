using ApplicationLayer.DbContext;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityDbContext
{
    public class EntityContext : DbContext, IEntityDbContext
    {
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Database> Databases { get; set; }
        public DbSet<DbRelationship> Relationships { get; set; }
        public DbSet<Move> Moves { get; set; }

        public EntityContext(DbContextOptions<EntityContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

    }
}
