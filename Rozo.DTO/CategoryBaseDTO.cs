using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;
using Rozo.Model;

namespace Rozo.DTO
{
    public class CategoryBaseDTO : IDTO
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        [PrimitiveProperty("Category", "Id", typeof(Category))]
        public int? Parent
        {
            get;
            set;
        }

        [Newtonsoft.Json.JsonProperty("can_add_question")]
        public bool CanAddQuestion
        {
            get;
            set;
        }
    }
}
