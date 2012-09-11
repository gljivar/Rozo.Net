using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class Solution : IModelObject
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

        public Question Question
        {
            get;
            set;
        }

        public User AddedBy
        {
            get;
            set;
        }

        public DateTime DateAdded
        {
            get;
            set;
        }

        public List<Rating> Ratings
        {
            get;
            set;
        }

        
    }
}
