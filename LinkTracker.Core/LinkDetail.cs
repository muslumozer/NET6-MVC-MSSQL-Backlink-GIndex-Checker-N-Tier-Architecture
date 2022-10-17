using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTracker.Core
{
    public class LinkDetail:BaseEntity
    {
        public string? Price { get; set; }
        public DateTime LinkStartDate { get; set; }
        public DateTime LinkExpiryDate { get; set; }
        public string? LinkType { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Link>? Links { get; set; }
    }
}
