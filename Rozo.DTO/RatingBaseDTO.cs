using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.DTO.Attributes;
using Rozo.Model;

namespace Rozo.DTO
{
    public class RatingBaseDTO : IDTO
    {
        public int Id
        {
            get;
            set;
        }

        [PrimitiveProperty("Solution", "Id", typeof(Solution))]
        public int Solution
        {
            get;
            set;
        }

        [ComplexProperty("RatedBy", typeof(User))]
        [Newtonsoft.Json.JsonProperty("rated_by")]
        public UserBaseDTO RatedBy
        {
            get;
            set;
        }
    }
}
