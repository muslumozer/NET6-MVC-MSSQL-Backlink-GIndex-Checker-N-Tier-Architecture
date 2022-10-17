using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTracker.Core
{
    public class Group:BaseEntity
    {
        public string? GroupName { get; set; }
        public ICollection<Link>? Links { get; set; }
    }
}
