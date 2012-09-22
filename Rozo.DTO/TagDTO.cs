using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;

namespace Rozo.DTO
{
    public class TagDTO : TagBaseDTO
    {
        [IgnorableBaseDTOProperty]
        public List<QuestionDTO> Questions
        {
            get;
            set;
        }
    }
}
