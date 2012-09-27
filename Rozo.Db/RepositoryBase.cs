using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using System.Data.Entity;

namespace Rozo.Db
{
    public class RepositoryBase<T> : IRepository<T>
        where T : class, IModelObject
    {
        protected DbContext context;

        public RepositoryBase(DbContext context)
        {
            this.context = context;
        }

        public virtual int Count()
        {
            return this.context.Set<T>().Count();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return this.context.Set<T>().ToList().AsEnumerable();
        }

        public virtual T GetById(int id)
        {
            // TODO: Refactor, maybe exception handling
            var results = this.context.Set<T>().Where(q => q.Id == id);

            if (results.Count() == 1)
            {
                return (results as IEnumerable<T>).ElementAt(0);
            }
            else
            {
                return new Rozo.Model.SpecialCaseManager().GetSpecialCaseClass(typeof(T)) as T;
            }
        }

        public virtual T Create(T item)
        {
            this.context.Set<T>().Add(item);
            this.context.SaveChanges();

            return item;
        }

        /// <summary>
        /// Update needs to be idempotent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="item"></param>
        public virtual void Update(int id, T item)
        {
            item.Id = id;

            var results = this.context.Set<T>().Where(q => q.Id == item.Id);

            if (results.Count() == 1)
            {
                var result = results.Single(r => r.Id == item.Id); // (results as IEnumerable<T>).ElementAt(0);
                var entry = this.context.Entry(result);

                Type modelObjectType = item.GetType();

                // Justification: Manual retrieving and setting of properties on mapped object, because Entity Framework can't do it automatically
                foreach (var propertyInfo in modelObjectType.GetProperties())
                {
                    var propertyValue = modelObjectType.GetProperty(propertyInfo.Name).GetValue(item, null);
                    if (propertyValue is IModelObject)
                    {
                        var newValue = this.context.Set(propertyValue.GetType()).Find((propertyValue as IModelObject).Id);
                        modelObjectType.GetProperty(propertyInfo.Name).SetValue(result, newValue, null);
                    }
                    else if (propertyValue is IEnumerable<IModelObject>)
                    {
                        Type listItemType = propertyValue.GetType().GetGenericArguments()[0];

                        // Justification: Here I am using dynamic values, because I can't cast newValue to List<IModelObject> because of covariance
                        // and in the loop I have to use dynamic because I can't add IModelObject to list because of same problem

                        // TODO: Fix this, because it adds new items to list if they don't exist. This needs to be controlled somehow.
                        dynamic newValue = Activator.CreateInstance(propertyValue.GetType()) as IEnumerable<IModelObject>;

                        foreach (var listItem in propertyValue as IEnumerable<IModelObject>)
                        {
                            dynamic listValue = this.context.Set(listItemType).Find((listItem as IModelObject).Id);
                            newValue.Add(listValue);
                        }

                        modelObjectType.GetProperty(propertyInfo.Name).SetValue(result, newValue, null); 
                    }
                }

                entry.State = System.Data.EntityState.Modified;
                entry.CurrentValues.SetValues(item);
                
                this.context.SaveChanges();
            }
        }

        public virtual void Delete(T item)
        {
            this.context.Set<T>().Remove(item);
            this.context.SaveChanges();
        }

        public virtual void DeleteById(int id)
        {
            // TODO: Refactor, maybe exception handling
            var results = this.context.Set<T>().Where(q => q.Id == id);

            if (results.Count() == 1)
            {
                var result = results.Single(q => q.Id == id);
                this.context.Set<T>().Remove(result);
                this.context.SaveChanges();
            }
        }
    }
}
