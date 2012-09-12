using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.Model.SpecialCase
{
    public class MissingCategory : Category
    {
        public override int Id
        {
            get
            {
                return -1;
            }
        }

        public override string Name
        {
            get
            {
                return "Missing Category";
            }
        }

        public override Category Parent
        {
            get
            {
                return new MissingCategory();
            }
        }

        public override bool CanAddQuestion
        {
            get
            {
                return false;
            }
        }

        public override List<Question> Questions
        {
            get
            {
                return new List<Question>();
            }
        }
    }
}
