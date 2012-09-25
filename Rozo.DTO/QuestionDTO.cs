using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;

namespace Rozo.DTO
{
    public class QuestionDTO : QuestionBaseDTO
    {
        [ComplexListProperty("Tags")]
        public List<TagBaseDTO> Tags
        {
            get;
            set;
        }

        [ComplexListProperty("Solutions")]
        public List<SolutionBaseDTO> Solutions
        {
            get;
            set;
        }
    }
}
