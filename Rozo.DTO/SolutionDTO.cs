using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.DTO
{
    public class SolutionDTO : SolutionBaseDTO
    {
        public List<ProvidedAnswerDTO> ProvidedAnswers
        {
            get;
            set;
        }

        public List<RatingDTO> Ratings
        {
            get;
            set;
        }
   
    }
}
