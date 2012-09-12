using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;

namespace Rozo.DTO.Adapters
{
    public class TagDTOAdapter : DTOAdapterBase<Tag, TagDTO>
    {

        public override TagDTO InitializeDTO(Tag modelObject)
        {
            var dto = new TagDTO();

            dto.Id = modelObject.Id;
            dto.Name = modelObject.Name;
            dto.Questions = new QuestionDTOAdapter().InitializeDTOs(modelObject.Questions).ToList();

            return dto;
        }

        public TagBaseDTO InitializeBaseDTO(Tag modelObject)
        {
            var dto = new TagBaseDTO();

            dto.Id = modelObject.Id;
            dto.Name = modelObject.Name;

            return dto;
        }

        public IEnumerable<TagBaseDTO> InitializeBaseDTOs(IEnumerable<Tag> modelObjects)
        {
            foreach (var modelObject in modelObjects)
            {
                yield return InitializeBaseDTO(modelObject);
            }
        }
    }
}
