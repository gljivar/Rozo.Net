using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Rozo.Model
{
    public class Solution : IModelObject, IEquatable<Solution>
    {
        [ScaffoldColumn(false)]
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

        #region Overriden Methods

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            return Equals((Solution)obj);
        }

        public bool Equals(Solution other)
        {

            if (this.Id != other.Id)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        #endregion
    }
}
