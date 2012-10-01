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
        [Newtonsoft.Json.JsonProperty("provided_answer")]
        public string ProvidedAnswer
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
    }
}
