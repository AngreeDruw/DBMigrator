using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DatabaseRelationship : EntityBase
    {
        public Database Leading { get; set; }
        public Guid LeadingId { get; set; }
        public Database Slave { get; set; }
        public Guid SlaveId { get; set; }
    }
}
