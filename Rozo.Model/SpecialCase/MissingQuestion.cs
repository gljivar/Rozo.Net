using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model.SpecialCase
{
    public sealed class MissingQuestion : Question, IMissingModelObject
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
                return "Missing Question";
            }
        }

        public override Category Category
        {
            get
            {
                return new MissingCategory();
            }
        }

        public override User AddedBy
        {
            get
            {
                return new MissingUser();
            }
        }

        public override bool Solved
        {
            get
            {
                return false;
            }
        }

        public override bool Open
        {
            get
            {
                return false;
            }
        }

        public override bool MultipleSolutions
        {
            get
            {
                return false;
            }
        }

        public override List<ProvidedAnswer> ProvidedAnswers
        {
            get
            {
                return new List<ProvidedAnswer>();
            }
        }

        public override List<Tag> Tags
        {
            get
            {
                return new List<Tag>();
            }
        }

        public override List<Solution> Solutions
        {
            get
            {
                return new List<Solution>();
            }
        }
    }
}
