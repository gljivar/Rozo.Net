using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class Question : IModelObject
    {
        public int Id
        {
            get;
            set;
        }

        public string Text
        {
            get;
            set;
        }

        public Category Category
        {
            get;
            set;
        }

        public User AddedBy
        {
            get;
            set;
        }

        public bool Solved
        {
            get;
            set;
        }

        public bool Open
        {
            get;
            set;
        }

        public bool MultipleSolutions
        {
            get;
            set;
        }

        public List<ProvidedAnswer> ProvidedAnswers
        {
            get;
            set;
        }

        public List<Tag> Tags
        {
            get;
            set;
        }

        public List<Solution> Solutions
        {
            get;
            set;
        }
    }
}
