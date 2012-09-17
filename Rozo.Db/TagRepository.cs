using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;
using Utility.Interfaces;
using Rozo.Model.SpecialCase;
using Rozo.Db.EF;

namespace Rozo.Db
{
    public class TagRepository : IRepository<Tag>
    {

        public IEnumerable<Tag> GetAll()
        {
            return new RozoContext().Tags;
        }

        public Tag GetById(int id)
        {
            // TODO: Refactor, maybe exception handling
            var results = new RozoContext().Tags.Where(q => q.Id == id);

            if (results.Count() == 1)
            {
                return results.ElementAt(0);
            }
            else
            {
                return new MissingTag();
            }

        }

        public void Create(Tag item)
        {
            using (var context = new RozoContext())
            {
                context.Tags.Add(item);
                context.SaveChanges();
            }

        }

        public void Update(Tag item)
        {
            try
            {
                using (var context = new RozoContext())
                {
                    if (context.Tags.Contains(item))
                    {
                        var itemToUpdate = context.Tags.Single(t => t.Id == item.Id);
                        itemToUpdate.Name = item.Name;
                        context.SaveChanges();
                    }
                }
            }
            catch
            {
                throw;
                // LOG
            }

        }

        public void Delete(Tag item)
        {
            using (var context = new RozoContext())
            {
                context.Tags.Remove(item);
                context.SaveChanges();
            }

        }

        public void DeleteById(int id)
        {
            using (var context = new RozoContext())
            {
                var tag = context.Tags.Single(t => t.Id == id);
                context.Tags.Remove(tag);
                context.SaveChanges();
            }
        }
    }
}
