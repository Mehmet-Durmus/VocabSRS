using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabSRS.Core.Entities
{
    public class StudiedWord : BaseEntity
    {
        public int BoxNumber { get; set; }

        // Relations
        public int WordId { get; set; }
        public Word Word { get; set; }
        public List<WordMeaning>? WordMeanings { get; set; }
        public List<Phrase>? Phrases { get; set; }
    }
}
