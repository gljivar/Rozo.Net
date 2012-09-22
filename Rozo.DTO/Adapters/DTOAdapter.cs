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

        //public QuestionBaseDTO InitializeBaseDTO(Question modelObject)
        //{
        //    var dto = new QuestionBaseDTO();

        //    //dto.Id = modelObject.Id;
        //    //dto.Question = modelObject.Text;
        //    //dto.Category = modelObject.Category != null ? (int?)modelObject.Category.Id : (int?)null;
        //    ////dto.AddedBy = new UserDTOAdapter().InitializeDTO(question.AddedBy);
        //    //dto.Solved = modelObject.Solved;
        //    //dto.Open = modelObject.Open;
        //    //dto.MultipleSolutions = modelObject.MultipleSolutions;

        //    return dto;
        //}
    }
}
