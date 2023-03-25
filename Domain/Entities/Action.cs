using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Action : EntityBase
    {
        public string Name { get; set; }
        public int SortNumber { get; set; } = 0;
        public DatabaseRelationship Relationship { get; set; }
        public Guid RelationshipId { get; set; }
        public string ActionJSON { get; set; }
    }
}
