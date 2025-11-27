using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabSRS.Core.Entities
{
    public class WordSentence : BaseEntity
    {
        public string Sentence { get; set; }

        // Relations
        public int WordMeaningId { get; set; }
        public WordMeaning WordMeaning { get; set; }
    }
}
