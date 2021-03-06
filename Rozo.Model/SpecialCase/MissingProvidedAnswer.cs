﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model.SpecialCase
{
    public class MissingProvidedAnswer : ProvidedAnswer, IMissingModelObject
    {
        public override int Id
        {
            get
            {
                return -1;
            }
        }

        public override string Text
        {
            get
            {
                return "Missing Provided Answer";
            }
        }

        public override Question Question
        {
            get
            {
                return new MissingQuestion();
            }
        }
    }
}
