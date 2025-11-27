using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabSRS.Core.Entities;

namespace VocabSRS.DAL.Configuration
{
    public class KnownWordConfiguration : BaseConfiguration<KnownWord>
    {
        public override void Configure(EntityTypeBuilder<KnownWord> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Word)
                .WithOne(x => x.KnownWord)
                .HasForeignKey<KnownWord>(x => x.WordId);
        }
    }
}
