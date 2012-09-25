using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.Model.SpecialCase
{
    public class MissingSolution : Solution, IMissingModelObject
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
                return "Missing Solution";
            }
        }

        public override User AddedBy
        {
            get
            {
                return new MissingUser();
            }
        }

        public override DateTime DateAdded
        {
            get
            {
                return DateTime.MinValue;
            }
        }

        public override List<ProvidedAnswer> ProvidedAnswers
        {
            get
            {
                return new List<ProvidedAnswer>();
            }
        }

        public override Question Question
        {
            get
            {
                return new MissingQuestion();
            }
        }

        public override List<Rating> Ratings
        {
            get
            {
                return new List<Rating>();
            }
        }
    }
}
