using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;

namespace Rozo.DTO.Adapters
{
    public class DTOAdapterManager
    {
        public object InitializeBaseDTO(object modelObject)
        {
            if (modelObject is Category)
            {
                return DTOAdapter<Category, CategoryBaseDTO, CategoryDTO>.InitializeBaseDTO(modelObject as Category);
            }
            else if (modelObject is ProvidedAnswer)
            {
                return DTOAdapter<ProvidedAnswer, ProvidedAnswerBaseDTO, ProvidedAnswerDTO>.InitializeBaseDTO(modelObject as ProvidedAnswer);
            }
            else if (modelObject is Question)
            {
                return DTOAdapter<Question, QuestionBaseDTO, QuestionDTO>.InitializeBaseDTO(modelObject as Question);
            }
            else if (modelObject is Rating)
            {
                return DTOAdapter<Rating, RatingBaseDTO, RatingDTO>.InitializeBaseDTO(modelObject as Rating);
            }
            else if (modelObject is Solution)
            {
                return DTOAdapter<Solution, SolutionBaseDTO, SolutionDTO>.InitializeBaseDTO(modelObject as Solution);
            }
            else if (modelObject is Tag)
            {
                return DTOAdapter<Tag, TagBaseDTO, TagDTO>.InitializeBaseDTO(modelObject as Tag);
            }
            else if (modelObject is User)
            {
                return DTOAdapter<User, UserBaseDTO, UserDTO>.InitializeBaseDTO(modelObject as User);
            }
            else
            {
                // TODO: Log Elmah + add custom exception type
                throw new Exception("Type not found");
            }
        }

        public object InitializeBaseDTOs(object modelObject)
        {
            if (modelObject is List<Category>)
            {
                return DTOAdapter<Category, CategoryBaseDTO, CategoryDTO>.InitializeBaseDTOs(modelObject as List<Category>).ToList();
            }
            else if (modelObject is List<ProvidedAnswer>)
            {
                return DTOAdapter<ProvidedAnswer, ProvidedAnswerBaseDTO, ProvidedAnswerDTO>.InitializeBaseDTOs(modelObject as List<ProvidedAnswer>).ToList();
            }
            else if (modelObject is List<Question>)
            {
                return DTOAdapter<Question, QuestionBaseDTO, QuestionDTO>.InitializeBaseDTOs(modelObject as List<Question>).ToList();
            }
            else if (modelObject is List<Rating>)
            {
                return DTOAdapter<Rating, RatingBaseDTO, RatingDTO>.InitializeBaseDTOs(modelObject as List<Rating>).ToList();
            }
            else if (modelObject is List<Solution>)
            {
                return DTOAdapter<Solution, SolutionBaseDTO, SolutionDTO>.InitializeBaseDTOs(modelObject as List<Solution>).ToList();
            }
            else if (modelObject is List<Tag>)
            {
                return DTOAdapter<Tag, TagBaseDTO, TagDTO>.InitializeBaseDTOs(modelObject as List<Tag>).ToList();
            }
            else if (modelObject is List<User>)
            {
                return DTOAdapter<User, UserBaseDTO, UserDTO>.InitializeBaseDTOs(modelObject as List<User>).ToList();
            }
            else
            {
                // TODO: Log Elmah + add custom exception type
                throw new Exception("Type not found");
            }
        }
    }
}
