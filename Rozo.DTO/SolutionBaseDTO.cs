using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.Model;
using Rozo.DTO.Attributes;

namespace Rozo.DTO
{
    public class SolutionBaseDTO : IDTO
    {
        public int Id
        {
            get;
            set;
        }

        [PropertyName("Text")]
        public string Solution
        {
            get;
            set;
        }

        [PrimitiveProperty("Question", "Id", typeof(Question))]
        public int Question
        {
            get;
            set;
        }

        [ComplexProperty("AddedBy", typeof(User))]
        public UserBaseDTO AddedBy
        {
            get;
            set;
        }

        public DateTime DateAdded
        {
            get;
            set;
        }

        [ComplexListProperty("ProvidedAnswers", typeof(List<ProvidedAnswer>))]
        public List<ProvidedAnswerBaseDTO> ProvidedAnswers
        {
            get;
            set;
        }
    }
}
