using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabSRS.Core.Entities
{
    public class Word : BaseEntity
    {
        public string WordText { get; set; }

        // Relations
        public KnownWord? KnownWord { get; set; }
        public StudiedWord? StudiedWord { get; set; }
    }
}
