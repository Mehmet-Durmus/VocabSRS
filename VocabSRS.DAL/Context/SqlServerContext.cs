using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VocabSRS.Core.Entities;

namespace VocabSRS.DAL.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) {}

        public DbSet<KnownWord> KnownWords { get; set; }
        public DbSet<Phrase> Phrases { get; set; }
        public DbSet<PhraseMeaning> PhraseMeanings { get; set; }
        public DbSet<PhraseSentence> PhraseSentences { get; set; }
        public DbSet<StudiedWord> StudiedWords { get; set; }
        public DbSet<TypeOfMeaning> TypeOfMeanings { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<WordMeaning> WordMeanings { get; set; }
        public DbSet<WordSentence> WordSentences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
