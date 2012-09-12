using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.Model.SpecialCase
{
    public class MissingRating : Rating
    {
        public override int Id
        {
            get
            {
                return -1;
            }
        }

        public override User RatedBy
        {
            get
            {
                return new MissingUser();
            }
        }

        public override Solution Solution
        {
            get
            {
                return new MissingSolution();
            }
        }
    }
}
