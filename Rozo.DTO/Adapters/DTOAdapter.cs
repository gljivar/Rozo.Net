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
            return InitializeDTOGenericMethod<DTBase>(modelObject);
        }

        public static DT InitializeDTO(MT modelObject)
        {
            return InitializeDTOGenericMethod<DT>(modelObject);
        }

        private static Typee InitializeDTOGenericMethod<Typee>(MT modelObject) 
            where Typee : class, IDTOBase
        {
            // TODO: Watch for Special Case pattern: like MissingQuestion

            Type dtoType = typeof(Typee);
            Type modelObjectType = typeof(MT);

            var dto = Activator.CreateInstance(dtoType) as Typee;

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

                    var newValue = new DTOAdapterManager().InitializeBaseDTO(value as IModelObject);

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

        public static IEnumerable<DTBase> InitializeBaseDTOs(IEnumerable<MT> modelObjects)
        {
            foreach (var modelObject in modelObjects)
            {
                yield return InitializeBaseDTO(modelObject);
            }
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
                var value = dtoPi.GetValue(dto, null);

                // Map
                if (customAttributes.Any(a => a.GetType() == typeof(PrimitivePropertyAttribute) && value != null))
                {
                    var primitiveProperty = dtoPi.GetCustomAttributes(typeof(PrimitivePropertyAttribute), true).Single() as PrimitivePropertyAttribute;

                    var newValue = Activator.CreateInstance(primitiveProperty.ModelPropertyType) as IModelObject;
                    newValue.Id = (int)value;

                    modelObjectType.GetProperty(propertyName).SetValue(modelObject, newValue, null);
                }
                else if (customAttributes.Any(a => a.GetType() == typeof(ComplexPropertyAttribute) && value != null))
                {
                    var primitiveProperty = dtoPi.GetCustomAttributes(typeof(ComplexPropertyAttribute), true).Single() as ComplexPropertyAttribute;

                    var newValue = Activator.CreateInstance(primitiveProperty.ModelPropertyType) as IModelObject;
                    newValue.Id = (value as IDTOBase).Id;

                    modelObjectType.GetProperty(propertyName).SetValue(modelObject, newValue, null);
                }
                else if (customAttributes.Any(a => a.GetType() == typeof(ComplexListPropertyAttribute) && value != null))
                {
                    var primitiveProperty = dtoPi.GetCustomAttributes(typeof(ComplexListPropertyAttribute), true).Single() as ComplexListPropertyAttribute;

                    // Justification: Here I am using dynamic values, because I can't cast newValue to List<IModelObject> because of covariance
                    // and in the loop I have to use dynamic because I can't add IModelObject to list because of same problem
                    dynamic newValue = Activator.CreateInstance(primitiveProperty.ModelPropertyType) as IEnumerable<IModelObject>;

                    Type itemType = newValue.GetType().GetGenericArguments()[0]; // use this...
                    
                    foreach (var dtoBase in value as IEnumerable<IDTOBase>)
                    {
                        dynamic listValue = Activator.CreateInstance(itemType);
                        listValue.Id = dtoBase.Id;
                        newValue.Add(listValue);
                    }

                    modelObjectType.GetProperty(propertyName).SetValue(modelObject, newValue, null);
                }
                else
                {
                    modelObjectType.GetProperty(propertyName).SetValue(modelObject, value, null);
                }
            }

            return modelObject;
        }
    }
}
