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
        public Type ModelPropertyType { get; set; }

        public PrimitivePropertyAttribute(string modelPropertyName, string modelPropertyPropertyName, Type modelPropertyType)
        {
            this.ModelPropertyName = modelPropertyName;
            this.ModelPropertyPropertyName = modelPropertyPropertyName;
            this.ModelPropertyType = modelPropertyType;
        }
    }
}
