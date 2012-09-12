using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class ProvidedAnswer : IModelObject
    {
        public virtual int Id
        {
            get;
            set;
        }

        public virtual string Text
        {
            get;
            set;
        }

        public virtual Question Question
        {
            get;
            set;
        }
    }
}
