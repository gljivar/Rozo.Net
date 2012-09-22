﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.DTO
{
    public class UserDTO : UserBaseDTO
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
