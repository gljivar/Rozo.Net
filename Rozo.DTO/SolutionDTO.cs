using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;
using Rozo.Model;

namespace Rozo.DTO
{
    public class SolutionDTO : SolutionBaseDTO
    {
        [ComplexListProperty("Ratings", typeof(List<Rating>))]
        public List<RatingBaseDTO> Ratings
        {
            get;
            set;
        }
   
    }
}
