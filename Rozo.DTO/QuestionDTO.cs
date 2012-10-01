using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;
using Rozo.Model;

namespace Rozo.DTO
{
    public class QuestionDTO : QuestionBaseDTO
    {

        [ComplexListProperty("Solutions", typeof(List<Solution>))]
        public List<SolutionBaseDTO> Solutions
        {
            get;
            set;
        }
    }
}
