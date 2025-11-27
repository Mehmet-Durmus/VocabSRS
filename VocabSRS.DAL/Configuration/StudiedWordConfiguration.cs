using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabSRS.Core.Entities;

namespace VocabSRS.DAL.Configuration
{
    public class StudiedWordConfiguration : BaseConfiguration<StudiedWord>
    {
        public override void Configure(EntityTypeBuilder<StudiedWord> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Word)
                .WithOne(x => x.StudiedWord)
                .HasForeignKey<StudiedWord>(x => x.WordId);
        }
    }
}
