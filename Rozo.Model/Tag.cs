using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Rozo.Model
{
    public class Tag : IModelObject, IEquatable<Tag>
    {
        [ScaffoldColumn(false)]
        public int Id
        {
            get;
            set;
        }

        [Required]
        public string Name
        {
            get;
            set;
        }

        public virtual List<Question> Questions
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

            return Equals((Tag)obj);
        }

        public bool Equals(Tag other)
        {
            if (this.Name != other.Name)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion
    }
}
