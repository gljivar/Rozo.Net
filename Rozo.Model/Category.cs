using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class Category : IModelObject
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public Category Parent
        {
            get;
            set;
        }

        public bool CanAddQuestion
        {
            get;
            set;
        }
    }
}
