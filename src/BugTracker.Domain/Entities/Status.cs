using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Domain.Entities
{
    public class Status
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

    }
}
