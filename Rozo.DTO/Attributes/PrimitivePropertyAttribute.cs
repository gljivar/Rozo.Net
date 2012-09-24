using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.DTO.Attributes
{
    public class PrimitivePropertyAttribute : Attribute
    {
        public string ModelPropertyName { get; set; }
        public string ModelPropertyPropertyName { get; set; }

        public PrimitivePropertyAttribute(string modelPropertyName, string modelPropertyPropertyName)
        {
            this.ModelPropertyName = modelPropertyName;
            this.ModelPropertyPropertyName = modelPropertyPropertyName;
        }
    }
}
