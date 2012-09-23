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
        [ModelDTOProperty("Questions", typeof(Rozo.Model.Question))]
        public List<QuestionDTO> Questions
        {
            get;
            set;
        }
    }
}
