using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationLayer.DbContext
{
    public interface IEntityDbContext
    {
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Database> Databases { get; set; }
        public DbSet<DbRelationship> Relationships { get; set; }
        public DbSet<Move> Moves { get; set; }
    }
}
