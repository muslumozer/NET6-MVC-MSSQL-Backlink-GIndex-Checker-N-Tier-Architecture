using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTracker.Core
{
    public class Link:BaseEntity
    {
        public DateTime LastScanDate { get; set; }
        public int ScanFrequency { get; set; }
        public int DomainId { get; set; }
        public Domain? Domain { get; set; }
        public ICollection<SubAndOtherPage>? SubAndOtherPages { get; set; }
        public int? LinkDetailId { get; set; }
        public LinkDetail? LinkDetail { get; set; }
        public int GroupId { get; set; }
        public Group? Group { get; set; }
        public int NoteId { get; set; }
        public Note? Note { get; set; }

    }
}
