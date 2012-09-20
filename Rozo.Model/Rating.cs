using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Rozo.Model
{
    public class Rating : IModelObject, IEquatable<Rating>
    {
        [ScaffoldColumn(false)]
        public virtual int Id
        {
            get;
            set;
        }

        public virtual Solution Solution
        {
            get;
            set;
        }

        public virtual User RatedBy
        {
            get;
            set;
        }

        public Question Question
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
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

            return Equals((Rating)obj);
        }

        public bool Equals(Rating other)
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
