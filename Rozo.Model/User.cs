using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Rozo.Model
{
    public class User : IModelObject, IEquatable<User>
    {
        [ScaffoldColumn(false)]
        public virtual int Id
        {
            get;
            set;
        }

        public virtual string Name
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

        public bool Equals(User other)
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
