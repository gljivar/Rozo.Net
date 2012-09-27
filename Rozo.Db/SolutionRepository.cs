using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.Model;
using System.Data.Entity;
using Rozo.Db.EF;

namespace Rozo.Db
{
    public class SolutionRepository : RepositoryBase<Solution>
    {
        public SolutionRepository()
            : base(new RozoContext())
        {
        }

        //public override void Update(int id, Solution item)
        //{
        //    // TODO: Check this out
        //    //var manager = project.Manager;
        //    //project.Manager = null;
        //    //context.Entry(project).State = EntityState.Modified;
        //    //// the line before did attach the object to the context
        //    //// with project.Manager == null
        //    //project.Manager = manager;
        //    //// this "fakes" a change of the relationship, EF will detect this
        //    //// and update the relatonship

        //    //var c = new Context();
        //    //var e = c.EmployeeTypes.Single(x => x.Text.Equals("second"));
        //    //var p = new Person
        //    //{
        //    //    Key = originalKey,       // same key
        //    //    FirstName = "NewFirst",  // new first name
        //    //    LastName = "NewLast"
        //    //};   // new last name
        //    //c.People.Attach(p); // Attach person first so that changes are tracked 
        //    //c.Entry(p).Reference(e => e.EmployeeType).Load();
        //    //p.EmployeeType = e; // Now context should know about the change
        //    //c.Entry(p).State = EntityState.Modified;
        //    //c.SaveChanges();

        //    var results = this.context.Set<Solution>().Where(q => q.Id == id);

        //    if (results.Count() == 1)
        //    {
        //        var result = results.Single(r => r.Id == id); // (results as IEnumerable<T>).ElementAt(0);

        //        var entry = this.context.Entry(result);

        //        Type modelObjectType = typeof(Solution);

        //        foreach (var pi in modelObjectType.GetProperties())
        //        {
        //            var currentPropertyValue = modelObjectType.GetProperty(pi.Name).GetValue(item, null);
        //            if (currentPropertyValue is IModelObject)
        //            {
        //                var value = this.context.Set(currentPropertyValue.GetType()).Find((currentPropertyValue as IModelObject).Id);
        //                modelObjectType.GetProperty(pi.Name).SetValue(result, value, null);  
        //            }
        //            else if (currentPropertyValue is IEnumerable<IModelObject>)
        //            {
        //                Type listType = currentPropertyValue.GetType();
        //                Type listItemType = listType.GetGenericArguments()[0];

        //                dynamic list = Activator.CreateInstance(listType) as IEnumerable<IModelObject>;

        //                foreach (var listItem in currentPropertyValue as IEnumerable<IModelObject>)
        //                {
        //                    dynamic value = this.context.Set(listItemType).Find((listItem as IModelObject).Id);
        //                    list.Add(value);
        //                }

        //                modelObjectType.GetProperty(pi.Name).SetValue(result, list, null);  

        //            }
                      
        //        } 
                
        //        item.Id = id;
        //        entry.State = System.Data.EntityState.Modified;
        //        entry.CurrentValues.SetValues(item);

        //        this.context.SaveChanges();
        //    }
        //}
    }
}
