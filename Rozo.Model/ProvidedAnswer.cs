using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model
{
    public class ProvidedAnswer : IModelObject, IEquatable<ProvidedAnswer>
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

        public bool Equals(ProvidedAnswer other)
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
