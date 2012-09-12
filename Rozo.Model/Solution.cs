using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class Solution : IModelObject
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

        public virtual User AddedBy
        {
            get;
            set;
        }

        public virtual DateTime DateAdded
        {
            get;
            set;
        }

        public virtual List<Rating> Ratings
        {
            get;
            set;
        }

        public virtual List<ProvidedAnswer> ProvidedAnswers
        {
            get;
            set;
        }

        
    }
}
