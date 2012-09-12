﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class Rating : IModelObject, IEquatable<Rating>
    {
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
