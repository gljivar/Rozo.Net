using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class Question : IModelObject
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

        public virtual Category Category
        {
            get;
            set;
        }

        public virtual User AddedBy
        {
            get;
            set;
        }

        public virtual bool Solved
        {
            get;
            set;
        }

        public virtual bool Open
        {
            get;
            set;
        }

        public virtual bool MultipleSolutions
        {
            get;
            set;
        }

        public virtual List<ProvidedAnswer> ProvidedAnswers
        {
            get;
            set;
        }

        public virtual List<Tag> Tags
        {
            get;
            set;
        }

        public virtual List<Solution> Solutions
        {
            get;
            set;
        }
    }
}
