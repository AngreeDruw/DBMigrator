using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    enum DatabaseTypes
    {
        MSSql
    }

    public class Database : EntityBase
    {
        string Name { get; set; }
        public string Description { get; set; }
        string ConnactionString { get; set; }
        DatabaseTypes DatabaseType { get; set; }
        Solution Solution { get; set; }
        Guid SolutionId { get; set; }
    }
}
