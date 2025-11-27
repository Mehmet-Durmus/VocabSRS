using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabSRS.Core.Entities
{
    public class TypeOfMeaning : BaseEntity
    {
        public string TypeText { get; set; }

        // Relations
        public List<WordMeaning>? WordMeanings { get; set; }
    }
}
