using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;
using Rozo.Model.SpecialCase;

namespace Rozo.Db
{
    public class QuestionRepository : Utility.Interfaces.IRepository<Question>
    {
        private List<Question> questions = new List<Question>()
        {
            new Question() {
                Id = 0, 
                Open = true, 
                Solved = false, 
                Text = "Are you blind?", 
                MultipleSolutions = false, 
                ProvidedAnswers = new List<ProvidedAnswer>() { new ProvidedAnswer() { Id = 0, Text = "Yes" }, new ProvidedAnswer() { Id = 1, Text = "No"} },
                Tags = new List<Tag>() { new Tag() { Id=0, Name = "Computer science" } }
            },
            new Question() {
                Id = 1, 
                Open = true, 
                Solved = false, 
                Text = "Are you cool?", 
                MultipleSolutions = false, 
                ProvidedAnswers = new List<ProvidedAnswer>() { new ProvidedAnswer() { Id = 2, Text = "Yes" }, new ProvidedAnswer() { Id = 3, Text = "No"}, new ProvidedAnswer() { Id = 3, Text = "Sometimes"}  },
                Tags = new List<Tag>() { new Tag() { Id=1, Name = "Math" } }
            }
        };


        public IEnumerable<Question> GetAll()
        {
            return questions;
        }

        public Question GetById(int id)
        {
            // TODO: Refactor, maybe exception handling
            var results = questions.Where(q => q.Id == id);

            if (results.Count() == 1)
            {
                return results.ElementAt(0);
            }
            else
            {
                return new MissingQuestion();
            }
        }
    }
}
