﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.DTO
{
    public class TagDTO : TagBaseDTO
    {
        public List<QuestionDTO> Questions
        {
            get;
            set;
        }
    }
}
