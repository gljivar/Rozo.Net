using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.DTO.Attributes
{
    public class ModelDTOPropertyAttribute
    {
        public string ModelPropertyName { get; set; }

        public ModelDTOPropertyAttribute(string modelPropertyName)
        {
            this.ModelPropertyName = modelPropertyName;
        }
    }
}
