using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;

namespace Rozo.DTO
{
    public class CategoryDTO : CategoryBaseDTO
    {
        [ComplexListProperty("Questions")]
        public List<QuestionBaseDTO> Questions
        {
            get;
            set;
        }
    }
}
