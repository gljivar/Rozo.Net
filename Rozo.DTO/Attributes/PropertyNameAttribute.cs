using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.DTO.Attributes
{
    public class PropertyNameAttribute : Attribute
    {
        public string ModelPropertyName { get; set; }

        public PropertyNameAttribute(string modelPropertyName)
        {
            this.ModelPropertyName = modelPropertyName;
        }
    }
}
