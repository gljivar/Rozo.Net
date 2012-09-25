using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;
using Utility.Interfaces;
using Rozo.Model.SpecialCase;

namespace Rozo.Db.Mock
{
    public class TagRepository : IRepository<Tag>
    {
        private static List<Tag> tags = new List<Tag>() 
        { 
            new Tag() { Id = 0, Name = "Matematika 1" }, 
            new Tag() { Id = 1, Name = "Fizika 1" }, 
            new Tag() { Id = 2, Name = "Osnove elektrotehnike"},
            new Tag() { Id = 3, Name = "Programiranje i programsko inženjerstvo" } 

            //new Tag() { Id = 0, Name = "Matematika 1", Questions = new List<Question>() }, 
            //new Tag() { Id = 1, Name = "Fizika 1", Questions = new List<Question>() }, 
            //new Tag() { Id = 2, Name = "Osnove elektrotehnike", Questions = new List<Question>() },
            //new Tag() { Id = 3, Name = "Programiranje i programsko inženjerstvo", Questions = new List<Question>() } 
        };

        public IEnumerable<Tag> GetAll()
        {
            return tags;
        }

        public Tag GetById(int id)
        {
            // TODO: Refactor, maybe exception handling
            var results = tags.Where(q => q.Id == id);

            if (results.Count() == 1)
            {
                return results.ElementAt(0);
            }
            else
            {
                return null; //new MissingTag();
            }
        }

        public Tag Create(Tag item)
        {
            tags.Add(item);
            return item;
        }

        public void Update(int id,Tag item)
        {
            if (tags.Contains(item))
            {
                var itemToUpdate = tags.Single(t => t.Id == item.Id);
                itemToUpdate.Name = item.Name;
            }
        }

        public void Delete(Tag item)
        {
            tags.Remove(item);
        }

        public void DeleteById(int id)
        {
            tags.Remove(tags.Single(t => t.Id == id));
        }


        public Tag CreateAndReturn(Tag item)
        {
            throw new NotImplementedException();
        }
    }
}
