using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTracker.Core
{
    public class SubAndOtherPage:BaseEntity
    {
        public string? PageUrl { get; set; }
        public int? DomainId { get; set; }
        public Domain? Domain { get; set; }
        public int? LinkId { get; set; }
        public Link? Link { get; set; }

    }
}
