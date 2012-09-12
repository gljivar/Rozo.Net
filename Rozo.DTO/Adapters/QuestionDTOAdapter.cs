using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;
using Utility.Interfaces;

namespace Rozo.DTO.Adapters
{
    public class QuestionDTOAdapter : DTOAdapterBase<Question, QuestionDTO>
    {
        // TODO: Spojit 2 metode u 2 ali ono, da nema dupliciranja

        public override QuestionDTO InitializeDTO(Question modelObject)
        {
            QuestionDTO dto = new QuestionDTO();

            dto.Id = modelObject.Id;
            dto.Question = modelObject.Text;
            dto.Category = modelObject.Category != null ? (int?)modelObject.Category.Id : (int?)null;
            //dto.AddedBy = new UserDTOAdapter().InitializeDTO(question.AddedBy);
            dto.Solved = modelObject.Solved;
            dto.Open = modelObject.Open;
            dto.MultipleSolutions = modelObject.MultipleSolutions;
            dto.ProvidedAnswers = null;
            dto.Tags = null;
            // PROVIDED ANSWERS
            // TAGS
            return dto;
        }

        public QuestionBaseDTO InitializeBaseDTO(Question modelObject)
        {
            var dto = new QuestionBaseDTO();

            dto.Id = modelObject.Id;
            dto.Question = modelObject.Text;
            dto.Category = modelObject.Category != null ? (int?)modelObject.Category.Id : (int?)null;
            //dto.AddedBy = new UserDTOAdapter().InitializeDTO(question.AddedBy);
            dto.Solved = modelObject.Solved;
            dto.Open = modelObject.Open;
            dto.MultipleSolutions = modelObject.MultipleSolutions;

            return dto;
        }

        public IEnumerable<QuestionBaseDTO> InitializeBaseDTOs(IEnumerable<Question> modelObjects)
        {
            foreach (var modelObject in modelObjects)
            {
                yield return InitializeBaseDTO(modelObject);
            }
        }
    }
}
