using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabSRS.Core.Entities
{
    public class PhraseMeaning : BaseEntity
    {
        public string Meaning { get; set; }

        // Relations
        public int PhraseId { get; set; }
        public Phrase Phrase { get; set; }
        public List<PhraseSentence>? PhraseSentences { get; set; }
    }
}
