﻿using System;
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
        private DbContext context;

        public RepositoryBase(DbContext context)
        {
            this.context = context;
        }

        public int Count()
        {
            return this.context.Set<T>().Count();
        }

        public IEnumerable<T> GetAll()
        {
            return this.context.Set<T>().ToList().AsEnumerable();
        }

        public T GetById(int id)
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

        public T Create(T item)
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
        public void Update(int id, T item)
        {
            // TODO: Check this out
            //var manager = project.Manager;
            //project.Manager = null;
            //context.Entry(project).State = EntityState.Modified;
            //// the line before did attach the object to the context
            //// with project.Manager == null
            //project.Manager = manager;
            //// this "fakes" a change of the relationship, EF will detect this
            //// and update the relatonship

            var results = this.context.Set<T>().Where(q => q.Id == id);

            if (results.Count() == 1)
            {
                var result = (results as IEnumerable<T>).ElementAt(0);

                var entry = this.context.Entry(result);
                item.Id = id;
                entry.State = System.Data.EntityState.Modified;
                entry.CurrentValues.SetValues(item);
                
                this.context.SaveChanges();
            }
        }

        public void Delete(T item)
        {
            this.context.Set<T>().Remove(item);
            this.context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            // TODO: Refactor, maybe exception handling
            var results = this.context.Set<T>().Where(q => q.Id == id);

            if (results.Count() == 1)
            {
                var result = (results as IEnumerable<T>).ElementAt(0);
                this.context.Set<T>().Remove(result);
                this.context.SaveChanges();
            }
        }
    }
}
