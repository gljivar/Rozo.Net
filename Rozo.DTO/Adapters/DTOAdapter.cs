using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using System.Reflection;

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
                // TODO: Check for Ignorable and Name attributes
                // This is basic implementation
                PropertyInfo modelObjectPi = modelObjectType.GetProperty(dtoPi.Name);

                var value = modelObjectPi.GetValue(modelObject, null);

                dtoType.GetProperty(dtoPi.Name).SetValue(dto, value, null);
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
            Type dtoType = typeof(DT);
            Type modelObjectType = typeof(MT);

            var dto = Activator.CreateInstance(dtoType) as DT;

            foreach (PropertyInfo dtoPi in dtoType.GetProperties())
            {
                // TODO: Check for Ignorable and Name attributes
                // This is basic implementation
                PropertyInfo modelObjectPi = modelObjectType.GetProperty(dtoPi.Name);

                var value = modelObjectPi.GetValue(modelObject, null);

                // TODO: For every object, make model to DTO transformation
                dtoType.GetProperty(dtoPi.Name).SetValue(dto, value, null);
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
                // TODO: Check for Ignorable and Name attributes
                // This is basic implementation
                PropertyInfo modelObjectPi = modelObjectType.GetProperty(dtoPi.Name);

                var value = dtoPi.GetValue(dto, null);

                // TODO: For every object, make model to DTO transformation
                modelObjectType.GetProperty(modelObjectPi.Name).SetValue(modelObject, value, null);
            }

            return modelObject;
        }
    }
}
