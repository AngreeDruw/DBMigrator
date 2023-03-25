using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public enum DatabaseTypes
    {
        MSSql
    }

    public class Database : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ConnactionString { get; set; }
        public DatabaseTypes DatabaseType { get; set; }
        public Solution Solution { get; set; }
        public Guid SolutionId { get; set; }
    }
}
