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

        [PrimitiveProperty("Category", "Id", typeof(Category))]
        public int? Category
        {
            get;
            set;
        }

        [PrimitiveProperty("User", "Id", typeof(User))]
        [Newtonsoft.Json.JsonProperty("add_by")]
        public int AddedBy
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

        [Newtonsoft.Json.JsonProperty("multiple_solutions")]
        public bool MultipleSolutions
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

        [ComplexListProperty("Tags", typeof(List<Tag>))]
        public List<TagBaseDTO> Tags
        {
            get;
            set;
        }
    }
}
