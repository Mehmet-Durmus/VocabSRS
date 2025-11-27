using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabSRS.Core.Entities
{
    public class WordMeaning : BaseEntity
    {
        public string Meaning { get; set; }

        // Relations
        public int StudiedWordId { get; set; }
        public StudiedWord StudiedWord { get; set; }
        public int TypeOfMeaningId { get; set; }
        public TypeOfMeaning TypeOfMeaning { get; set; }
        public List<WordSentence>? WordSentences { get; set; }
    }
}
