using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.DTO.Attributes
{
    public class PropertyAttribute : Attribute
    {
        public string ModelPropertyName { get; set; }
        public Type ModelPropertyType { get; set; }

        public PropertyAttribute(string modelPropertyName, Type modelPropertyType)
        {
            this.ModelPropertyName = modelPropertyName;
            this.ModelPropertyType = modelPropertyType;
        }
    }
}
