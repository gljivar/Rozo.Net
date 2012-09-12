using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.DTO
{
    public class QuestionDTO : QuestionBaseDTO
    {
        public List<ProvidedAnswerDTO> ProvidedAnswers
        {
            get;
            set;
        }

        public List<TagDTO> Tags
        {
            get;
            set;
        }

        public List<SolutionDTO> Solutions
        {
            get;
            set;
        }
    }
}
