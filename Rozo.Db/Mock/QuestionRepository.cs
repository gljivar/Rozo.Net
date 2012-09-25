using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;
using Rozo.Model.SpecialCase;

namespace Rozo.Db.Mock
{
    public class QuestionRepository : Utility.Interfaces.IRepository<Question>//, Utility.Interfaces.IDataMapper<Question>
    {
        private static List<Question> questions = new List<Question>()
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

        public int Count()
        {
            return 1;
        }

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

        public Question Create(Question item)
        {
            questions.Add(item);

            return item;
        }

        public void Update(int id, Question item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Question item)
        {
            questions.Remove(item);
        }

        public void DeleteById(int id)
        {
            var questionsToRemove = questions.ToList().Where(q => q.Id == id);//.Select(q => q.Id);
            foreach(var questionToRemove in questionsToRemove)
            {
                //questions.Remove(questions.Single(q => q.Id == idToRemove));
                questions.Remove(questionToRemove);
            }
        }


        public Question CreateAndReturn(Question item)
        {
            throw new NotImplementedException();
        }
    }
}
