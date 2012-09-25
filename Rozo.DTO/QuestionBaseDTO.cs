using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;
using Rozo.Model;

namespace Rozo.DTO
{
    public class QuestionBaseDTO : IDTO
    {
        public int Id
        {
            get;
            set;
        }

        [PropertyName("Text")]
        public string Question
        {
            get;
            set;
        }

        [PrimitiveProperty("Category", "Id")]
        public int? Category
        {
            get;
            set;
        }

        [PrimitiveProperty("User", "Id")]
        public int AddedBy
        {
            get;
            set;
        }

        public bool Solved
        {
            get;
            set;
        }

        public bool Open
        {
            get;
            set;
        }

        public bool MultipleSolutions
        {
            get;
            set;
        }

        [ComplexListProperty("ProvidedAnswers")]
        public List<ProvidedAnswerBaseDTO> ProvidedAnswers
        {
            get;
            set;
        }
    }
}
