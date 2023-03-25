using Domain.Entities.Base;

namespace Domain.Entities
{
    public class DbRelationship : EntityBase
    {
        public Database Leading { get; set; }
        public Guid LeadingId { get; set; }
        public Database Slave { get; set; }
        public Guid SlaveId { get; set; }
    }
}
