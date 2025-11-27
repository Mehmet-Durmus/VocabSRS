using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabSRS.Core.Entities
{
    public class Phrase : BaseEntity
    {
        public string PhraseText { get; set; }

        // Relations
        public int StudiedWordId { get; set; }
        public StudiedWord StudiedWord { get; set; }
        public List<PhraseMeaning>? PhraseMeanings { get; set; }
    }
}
