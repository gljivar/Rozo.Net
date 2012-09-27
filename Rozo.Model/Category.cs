using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Rozo.Model
{
    public class Category : IModelObject, IEquatable<Category>
    {
        [ScaffoldColumn(false)]
        public virtual int Id
        {
            get;
            set;
        }

        [Required]
        public virtual string Name
        {
            get;
            set;
        }

        public virtual Category Parent
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public virtual bool CanAddQuestion
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

            return Equals((Category)obj);
        }

        public bool Equals(Category other)
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
