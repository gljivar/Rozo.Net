﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.DTO
{
    public class SolutionBaseDTO : IDTO
    {
        public int Id
        {
            get;
            set;
        }

        public string Solution
        {
            get;
            set;
        }

        public int Question
        {
            get;
            set;
        }

        public UserDTO AddedBy
        {
            get;
            set;
        }

        public DateTime DateAdded
        {
            get;
            set;
        }

   
    }
}