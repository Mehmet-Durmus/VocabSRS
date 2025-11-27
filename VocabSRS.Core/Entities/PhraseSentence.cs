using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabSRS.Core.Entities
{
    public class PhraseSentence : BaseEntity
    {
        public string Sentence { get; set; }

        // Relations
        public int PhraseMeaningId { get; set; }
        public PhraseMeaning PhraseMeaning { get; set; }
    }
}
