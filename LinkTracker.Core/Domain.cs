using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTracker.Core
{
    public class Domain:BaseEntity
    {
        public string? DomainUrl { get; set; }

        public ICollection<Link>? Links { get; set; }

        public ICollection<SubAndOtherPage>? SubAndOtherPages { get; set; }
    }
}
