using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTracker.Core
{
    public class Note:BaseEntity
    {
        public string? NoteContent { get; set; }
        public ICollection<Link>? Links { get; set; }
    }
}
