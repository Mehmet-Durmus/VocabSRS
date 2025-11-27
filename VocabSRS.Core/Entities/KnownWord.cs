using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabSRS.Core.Entities
{
    public class KnownWord : BaseEntity
    {
        // Relations
        public int WordId { get; set; }
        public Word Word { get; set; }
    }
}
