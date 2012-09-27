using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Rozo.Model;
using System.Data.Entity.ModelConfiguration.Conventions;
using Rozo.Model.SpecialCase;

namespace Rozo.Db.EF
{
    public class RozoContext : DbContext
    {
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ProvidedAnswer> ProvidedAnswers { get; set; }
        public DbSet<Solution> Solutions { get; set; }

        public RozoContext()
            : base("name=DefaultConnection")
        {
        }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); 

            MapTag(modelBuilder);
            MapUser(modelBuilder);
            MapCategory(modelBuilder);
            MapQuestion(modelBuilder);
            MapRating(modelBuilder);
            MapProvidedAnswer(modelBuilder);
            MapSolution(modelBuilder);
        }

        // In mappings
        // k - key
        // p - property
        // r - relationship

        private void MapTag(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<MissingTag>();
        }

        private void MapUser(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<MissingUser>();
        }

        private void MapCategory(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<MissingCategory>();
        }

        private void MapQuestion(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<MissingQuestion>();
        }

        private void MapRating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<MissingRating>();
        }

        private void MapProvidedAnswer(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<MissingProvidedAnswer>();
        }

        private void MapSolution(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<MissingSolution>();
        }
    }
}
