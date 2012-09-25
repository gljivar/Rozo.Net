using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using System.Reflection;
using Rozo.DTO.Attributes;

namespace Rozo.DTO.Adapters
{
    public class DTOAdapter<MT, DTBase, DT>
        where MT : class, IModelObject
        where DTBase : class, IDTOBase
        where DT : class, IDTO      
    {
        public static DTBase InitializeBaseDTO(MT modelObject)
        {
            Type dtoType = typeof(DTBase);
            Type modelObjectType = typeof(MT);

            var dto = Activator.CreateInstance(dtoType) as DTBase;

            foreach (PropertyInfo dtoPi in dtoType.GetProperties())
            {
                var customAttributes = dtoPi.GetCustomAttributes(true);

                // Get property name
                var propertyName = dtoPi.Name;
                if (customAttributes.Any(a => a.GetType() == typeof(PropertyNameAttribute)))
                {
                    propertyName = (customAttributes.First() as PropertyNameAttribute).ModelPropertyName;
                }

                PropertyInfo modelObjectPi = modelObjectType.GetProperty(propertyName);
                var value = modelObjectPi.GetValue(modelObject, null);

                // Map
                if (customAttributes.Any(a => a.GetType() == typeof(PrimitivePropertyAttribute) && value != null))
                {
                    var primitiveProperty = dtoPi.GetCustomAttributes(typeof(PrimitivePropertyAttribute), true).Single() as PrimitivePropertyAttribute;

                    PropertyInfo propertyPi = value.GetType().GetProperty(primitiveProperty.ModelPropertyPropertyName);

                    var newValue = propertyPi.GetValue(value, null);

                    dtoType.GetProperty(dtoPi.Name).SetValue(dto, newValue, null);
                }
                else if (customAttributes.Any(a => a.GetType() == typeof(ComplexPropertyAttribute) && value != null))
                {
                    var modelDTOPrimitiveProperty = dtoPi.GetCustomAttributes(typeof(ComplexPropertyAttribute), true).Single() as ComplexPropertyAttribute;

                    var newValue = new DTOAdapterManager().InitializeBaseDTO(value);

                    dtoType.GetProperty(dtoPi.Name).SetValue(dto, newValue, null);
                }
                else
                {
                    dtoType.GetProperty(dtoPi.Name).SetValue(dto, value, null);
                }
            }

            return dto;
        }

        public static IEnumerable<DTBase> InitializeBaseDTOs(IEnumerable<MT> modelObjects)
        {
            foreach (var modelObject in modelObjects)
            {
                yield return InitializeBaseDTO(modelObject);
            }
        }

        public static DT InitializeDTO(MT modelObject)
        {
            // TODO: Watch for Special Case pattern: like MissingQuestion

            Type dtoType = typeof(DT);
            Type modelObjectType = typeof(MT);

            var dto = Activator.CreateInstance(dtoType) as DT;

            foreach (PropertyInfo dtoPi in dtoType.GetProperties())
            {
                var customAttributes = dtoPi.GetCustomAttributes(true);

                // Get property name
                var propertyName = dtoPi.Name;
                if (customAttributes.Any(a => a.GetType() == typeof(PropertyNameAttribute)))
                {
                    propertyName = (customAttributes.First() as PropertyNameAttribute).ModelPropertyName;
                }

                PropertyInfo modelObjectPi = modelObjectType.GetProperty(propertyName);
                var value = modelObjectPi.GetValue(modelObject, null);

                // Map
                if (customAttributes.Any(a => a.GetType() == typeof(PrimitivePropertyAttribute) && value != null))
                {
                    var primitiveProperty = dtoPi.GetCustomAttributes(typeof(PrimitivePropertyAttribute), true).Single() as PrimitivePropertyAttribute;

                    PropertyInfo propertyPi = value.GetType().GetProperty(primitiveProperty.ModelPropertyPropertyName);

                    var newValue = propertyPi.GetValue(value, null);

                    dtoType.GetProperty(dtoPi.Name).SetValue(dto, newValue, null);
                }
                else if (customAttributes.Any(a => a.GetType() == typeof(ComplexPropertyAttribute) && value != null))
                {
                    var modelDTOPrimitiveProperty = dtoPi.GetCustomAttributes(typeof(ComplexPropertyAttribute), true).Single() as ComplexPropertyAttribute;

                    var newValue = new DTOAdapterManager().InitializeBaseDTO(value);

                    dtoType.GetProperty(dtoPi.Name).SetValue(dto, newValue, null);
                }
                else if (customAttributes.Any(a => a.GetType() == typeof(ComplexListPropertyAttribute) && value != null))
                {
                    var modelDTOProperty = dtoPi.GetCustomAttributes(typeof(ComplexListPropertyAttribute), true).Single() as ComplexListPropertyAttribute;

                    var newValue = new DTOAdapterManager().InitializeBaseDTOs(value);

                    dtoType.GetProperty(dtoPi.Name).SetValue(dto, newValue, null);

                }
                else
                {
                    dtoType.GetProperty(dtoPi.Name).SetValue(dto, value, null);
                }

            }

            return dto;
        }

        public static MT InitializeBaseModelObject(DTBase dto)
        {
            Type dtoType = typeof(DTBase);
            Type modelObjectType = typeof(MT);

            var modelObject = Activator.CreateInstance(modelObjectType) as MT;

            foreach (PropertyInfo dtoPi in dtoType.GetProperties())
            {
                var customAttributes = dtoPi.GetCustomAttributes(true);

                // Get property name
                var propertyName = dtoPi.Name;
                if (customAttributes.Any(a => a.GetType() == typeof(PropertyNameAttribute)))
                {
                    propertyName = (customAttributes.First() as PropertyNameAttribute).ModelPropertyName;
                }

                PropertyInfo modelObjectPi = modelObjectType.GetProperty(propertyName);
                var value = modelObjectPi.GetValue(modelObject, null);

                // Map
                if (customAttributes.Any(a => a.GetType() == typeof(PrimitivePropertyAttribute) && value != null))
                {
                    var primitiveProperty = dtoPi.GetCustomAttributes(typeof(PrimitivePropertyAttribute), true).Single() as PrimitivePropertyAttribute;

                    PropertyInfo propertyPi = value.GetType().GetProperty(primitiveProperty.ModelPropertyPropertyName);

                    var newValue = propertyPi.GetValue(value, null);

                    dtoType.GetProperty(dtoPi.Name).SetValue(dto, newValue, null);
                }
                else if (customAttributes.Any(a => a.GetType() == typeof(ComplexPropertyAttribute) && value != null))
                {
                    var modelDTOPrimitiveProperty = dtoPi.GetCustomAttributes(typeof(ComplexPropertyAttribute), true).Single() as ComplexPropertyAttribute;

                    var newValue = new DTOAdapterManager().InitializeBaseDTO(value);

                    dtoType.GetProperty(dtoPi.Name).SetValue(dto, newValue, null);
                }
                else
                {
                    dtoType.GetProperty(dtoPi.Name).SetValue(dto, value, null);
                }
            }

            return modelObject;
        }

        //public static MT InitializeBaseModelObject(DTBase dto)
        //{
        //    Type dtoType = typeof(DTBase);
        //    Type modelObjectType = typeof(MT);

        //    var modelObject = Activator.CreateInstance(modelObjectType) as MT;

        //    foreach (PropertyInfo dtoPi in dtoType.GetProperties())
        //    {
        //        // TODO: Check for Ignorable and Name attributes
        //        // This is basic implementation
        //        PropertyInfo modelObjectPi = modelObjectType.GetProperty(dtoPi.Name);

        //        var value = dtoPi.GetValue(dto, null);

        //        // TODO: For every object, make model to DTO transformation
        //        modelObjectType.GetProperty(modelObjectPi.Name).SetValue(modelObject, value, null);
        //    }

        //    return modelObject;
        //}
    }
}
