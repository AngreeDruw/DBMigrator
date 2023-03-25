using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Move : EntityBase
    {
        public string Name { get; set; }
        public int SortNumber { get; set; } = 0;
        public DbRelationship Relationship { get; set; }
        public Guid RelationshipId { get; set; }
        public string ActionJSON { get; set; }
    }
}
