using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;
using Rozo.Model;

namespace Rozo.DTO
{
    public class ProvidedAnswerBaseDTO : IDTO
    {
        public int Id
        {
            get;
            set;
        }

        [PropertyName("Text")]
        public string ProvidedAnswer
        {
            get;
            set;
        }

        [PrimitiveProperty("Question", "Id")]
        public int Question
        {
            get;
            set;
        }
    }
}
