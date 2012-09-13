using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.Model.SpecialCase
{
    public class MissingTag : Tag
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
                return "Missing Tag";
            }
        }

        //public override List<Question> Questions
        //{
        //    get
        //    {
        //        return new List<Question>();
        //    }
        //}
    }

}
