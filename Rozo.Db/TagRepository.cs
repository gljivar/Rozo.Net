using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;
using Utility.Interfaces;

namespace Rozo.Db
{
    public class TagRepository : IRepository<Tag>
    {
        private static List<Tag> tags = new List<Tag>() 
        { 
            new Tag() { Id = 0, Name = "Matematika 1", Questions = new List<Question>() }, 
            new Tag() { Id = 1, Name = "Fizika 1", Questions = new List<Question>() }, 
            new Tag() { Id = 2, Name = "Osnove elektrotehnike", Questions = new List<Question>() },
            new Tag() { Id = 3, Name = "Programiranje i programsko inženjerstvo", Questions = new List<Question>() } 
        };

        public IEnumerable<Tag> GetAll()
        {
            return tags;
        }

        public Tag GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Tag item)
        {
            throw new NotImplementedException();
        }

        public void Update(Tag item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tag item)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
