using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.DTO.Attributes
{
    public class ComplexListPropertyAttribute : Attribute
    {
        public string ModelPropertyName { get; set; }

        public ComplexListPropertyAttribute(string modelPropertyName)
        {
            this.ModelPropertyName = modelPropertyName;
        }
    }
}
