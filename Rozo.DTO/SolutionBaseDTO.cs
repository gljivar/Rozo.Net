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
        [Newtonsoft.Json.JsonProperty("add_by")]
        public UserBaseDTO AddedBy
        {
            get;
            set;
        }

        [Newtonsoft.Json.JsonProperty("date_added")]
        public DateTime DateAdded
        {
            get;
            set;
        }

        [ComplexListProperty("ProvidedAnswers", typeof(List<ProvidedAnswer>))]
        [Newtonsoft.Json.JsonProperty("provided_answers")]
        public List<ProvidedAnswerBaseDTO> ProvidedAnswers
        {
            get;
            set;
        }
    }
}
