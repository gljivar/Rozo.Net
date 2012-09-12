using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class Rating : IModelObject
    {
        public virtual int Id
        {
            get;
            set;
        }

        public virtual Solution Solution
        {
            get;
            set;
        }

        public virtual User RatedBy
        {
            get;
            set;
        }
    }
}
