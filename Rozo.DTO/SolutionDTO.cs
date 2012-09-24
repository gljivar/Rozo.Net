using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;

namespace Rozo.DTO
{
    public class SolutionDTO : SolutionBaseDTO
    {
        [ComplexListProperty("ProvidedAnswers")]
        public List<ProvidedAnswerBaseDTO> ProvidedAnswers
        {
            get;
            set;
        }

        [ComplexListProperty("Ratings")]
        public List<RatingBaseDTO> Ratings
        {
            get;
            set;
        }
   
    }
}
