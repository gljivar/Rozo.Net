using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class Rating : IModelObject
    {
        public int Id
        {
            get;
            set;
        }

        public Solution Solution
        {
            get;
            set;
        }

        public User RatedBy
        {
            get;
            set;
        }
    }
}
