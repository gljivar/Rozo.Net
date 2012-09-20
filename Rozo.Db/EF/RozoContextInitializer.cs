using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Rozo.Model;

namespace Rozo.Db.EF
{
    public class RozoContextInitializer : DropCreateDatabaseAlways<RozoContext> // DropCreateDatabaseIfModelChanges<RozoContext>
    {
        protected override void Seed(RozoContext context)
        {
            var users = new List<User>()
            {
                new User() { Name = "Miroslav" },
                new User() { Name = "Krešo"}
            };

            var tags = new List<Tag>() 
            { 
                new Tag() { Name = "Pitanja s prvog međuispita" }, 
                new Tag() { Name = "Pitanje s drugog međuispita" }, 
                new Tag() { Name = "Pitanje sa završnog međuispita"},
                new Tag() { Name = "Vježba" } 
            };

            var parentCategories = new List<Category>()
            {
                new Category() { Name = "Prvi semestar", CanAddQuestion = false },
                new Category() { Name = "Drugi semestar", CanAddQuestion = false },
            };

            var childCategories = new List<Category>()
            {
                    new Category() { Name = "Matematika 1", CanAddQuestion = true, Parent = parentCategories.Single(c => c.Name == "Prvi semestar")},
                    new Category() { Name = "Osnove elektrotehnike", CanAddQuestion = true, Parent = parentCategories.Single(c => c.Name == "Prvi semestar") },
                    new Category() { Name = "Fizika 1", CanAddQuestion = true, Parent = parentCategories.Single(c => c.Name == "Prvi semestar") },
                    new Category() { Name = "Programiranje i programsko inženjerstvo", CanAddQuestion = true, Parent = parentCategories.Single(c => c.Name == "Prvi semestar") },
                    new Category() { Name = "Fizika 2", CanAddQuestion = true, Parent = parentCategories.Single(c => c.Name == "Drugi semestar") }
            };

            var categories = new List<Category>();
            categories.AddRange(parentCategories);
            categories.AddRange(childCategories);

            var questions = new List<Question>()
            {
                new Question() { Text = "Koliko je 2 + 2?", AddedBy = users.Single(u => u.Name == "Miroslav"), Tags = new List<Tag>() { tags.Single(t => t.Name == "Vježba")}, Category = categories.Single(c => c.Name == "Matematika 1"), Open = true, Solved = false, MultipleSolutions = false }
            };

            users.ForEach(u => context.Users.Add(u));
            tags.ForEach(t => context.Tags.Add(t));
            categories.ForEach(c => context.Categories.Add(c));
            questions.ForEach(q => context.Questions.Add(q));

            context.SaveChanges();
        }
    }
}
