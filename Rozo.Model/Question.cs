using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.Model
{
    public class Question
    {
        public int? Id
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

        public User AddBy
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

        public List<Answer> ProvidedAnswers
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
