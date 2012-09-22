﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.DTO
{
    public class ProvidedAnswerBaseDTO : IDTO
    {
        public int Id
        {
            get;
            set;
        }

        public string ProvidedAnswer
        {
            get;
            set;
        }

        public int Question
        {
            get;
            set;
        }
    }
}
