using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Rozo.Model
{
    public class Question : IModelObject, IEquatable<Question>
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

            return Equals(obj);
        }

        public bool Equals(Question other)
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
