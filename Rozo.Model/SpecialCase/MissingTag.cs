using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.Model.SpecialCase
{
    // TODO: vratiti missing tag gdje se pojavljivat treba
    public class MissingTag : Tag
    {
        public new int Id
        {
            get
            {
                return -1;
            }
        }

        public new string Name
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
