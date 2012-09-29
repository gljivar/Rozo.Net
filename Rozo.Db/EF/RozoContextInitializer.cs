using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Rozo.Model;

namespace Rozo.Db.EF
{
    public class RozoContextInitializer : DropCreateDatabaseAlways<RozoContext> // DropCreateDatabaseIfModelChanges<RozoContext> // 
    {
        protected override void Seed(RozoContext context)
        {
            var users = new List<User>()
            {
                new User() { Name = "Miroslav" },
                new User() { Name = "Krešo"},
                new User() { Name = "Miłosz"}
            };

            var tags = new List<Tag>() 
            { 
                new Tag() { Name = "Pitanja s prvog međuispita" }, 
                new Tag() { Name = "Pitanje s drugog međuispita" }, 
                new Tag() { Name = "Pitanje sa završnog međuispita"},
                new Tag() { Name = "Vježba" },
                new Tag() { Name = "Teorija" }, 
                new Tag() { Name = "Praktični rad" }, 
                new Tag() { Name = "Elementarna matematika"},
                new Tag() { Name = "Teško" } ,
                new Tag() { Name = "Laboratorijske vježbe" }, 
                new Tag() { Name = "Singleton" }, 
                new Tag() { Name = "Patterns"},
                new Tag() { Name = "Elektroenergetika" } 
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
                new Question() { Text = "Koliko je 2 + 2?", AddedBy = users.Single(u => u.Name == "Miroslav"), Tags = new List<Tag>() { tags.Single(t => t.Name == "Vježba")}, Category = categories.Single(c => c.Name == "Matematika 1"), Open = true, Solved = false, MultipleSolutions = true },
                new Question() { Text = "Koja je formula za težinu?", AddedBy = users.Single(u => u.Name == "Krešo"), Tags = new List<Tag>() { tags.Single(t => t.Name == "Pitanja s prvog međuispita")}, Category = categories.Single(c => c.Name == "Fizika 1"), Open = false, Solved = true, MultipleSolutions = false }
            };

            var providedAnswers = new List<ProvidedAnswer>()
            {
                new ProvidedAnswer() { Question = questions.Single(q => q.Text == "Koliko je 2 + 2?"), Text = "1"},
                new ProvidedAnswer() { Question = questions.Single(q => q.Text == "Koliko je 2 + 2?"), Text = "2"},
                new ProvidedAnswer() { Question = questions.Single(q => q.Text == "Koliko je 2 + 2?"), Text = "3"},
                new ProvidedAnswer() { Question = questions.Single(q => q.Text == "Koliko je 2 + 2?"), Text = "4"}
            };

            var solutions = new List<Solution>()
            {
                new Solution() { Text = "Ja mislim da je 3 ali nisam siguran.", AddedBy = users.Single(u => u.Name == "Miroslav"), DateAdded = DateTime.Now, Question = questions.Single(q => q.Text == "Koliko je 2 + 2?"), ProvidedAnswers = new List<ProvidedAnswer>() {providedAnswers.Single(p => p.Text == "3")} },
                new Solution() { Text = "Ma nema šanse, definitivno je 4.", AddedBy = users.Single(u => u.Name == "Krešo"), DateAdded = DateTime.Now.AddHours(1), Question = questions.Single(q => q.Text == "Koliko je 2 + 2?"), ProvidedAnswers = new List<ProvidedAnswer>() {providedAnswers.Single(p => p.Text == "4")} },
            };

            var ratings = new List<Rating>()
            {
                new Rating() { Question = questions.Single(q => q.Text == "Koliko je 2 + 2?"), RatedBy = users.Single(u => u.Name == "Miłosz"), Solution = solutions.Single(s => s.Text == "Ma nema šanse, definitivno je 4.") },
                new Rating() { Question = questions.Single(q => q.Text == "Koliko je 2 + 2?"), RatedBy = users.Single(u => u.Name == "Miroslav"), Solution = solutions.Single(s => s.Text == "Ma nema šanse, definitivno je 4.") }
            };

            users.ForEach(u => context.Users.Add(u));
            tags.ForEach(t => context.Tags.Add(t));
            categories.ForEach(c => context.Categories.Add(c));
            questions.ForEach(q => context.Questions.Add(q));
            providedAnswers.ForEach(p => context.ProvidedAnswers.Add(p));
            solutions.ForEach(s => context.Solutions.Add(s));
            ratings.ForEach(r => context.Ratings.Add(r));

            context.SaveChanges();
        }
    }
}
