using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.Model.SpecialCase;

namespace Rozo.Model
{
    public class SpecialCaseManager
    {
        public IModelObject GetSpecialCaseClass(Type o)
        {
            if (o.FullName == typeof(Category).FullName)
            {
                return new MissingCategory();
            }
            else if (o.FullName == typeof(ProvidedAnswer).FullName)
            {
                return new MissingProvidedAnswer();
            }
            else if (o.FullName == typeof(Question).FullName)
            {
                return new MissingQuestion();
            }
            else if (o.FullName == typeof(Rating).FullName)
            {
                return new MissingRating();
            }
            else if (o.FullName == typeof(Solution).FullName)
            {
                return new MissingSolution();
            }
            else if (o.FullName == typeof(Tag).FullName)
            {
                return null; // new MissingTag();
            }
            else if (o.FullName == typeof(User).FullName)
            {
                return new MissingUser();
            }
            else
            {
                throw new Exception("Special case class not found for type: " + o.GetType());
            }
        }
    }
}
