using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class Category : IModelObject
    {
        public virtual int Id
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }

        public virtual Category Parent
        {
            get;
            set;
        }

        public virtual bool CanAddQuestion
        {
            get;
            set;
        }
    }
}
