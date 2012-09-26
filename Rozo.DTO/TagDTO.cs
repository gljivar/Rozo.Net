using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;
using Rozo.Model;

namespace Rozo.DTO
{
    public class TagDTO : TagBaseDTO
    {
        [ComplexListProperty("Questions", typeof(List<Question>))]
        public List<QuestionBaseDTO> Questions
        {
            get;
            set;
        }
    }
}
