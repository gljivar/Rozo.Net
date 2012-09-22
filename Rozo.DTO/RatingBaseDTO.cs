using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.DTO
{
    public class RatingDTO : IDTO
    {
        public int Id
        {
            get;
            set;
        }

        public int Solution
        {
            get;
            set;
        }

        public UserDTO RatedBy
        {
            get;
            set;
        }
    }
}
