using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;
using Utility.Interfaces;

namespace Rozo.DTO.Adapters
{
    public class DTOAdapterManager
    {
        public IDTOBase InitializeBaseDTO(IModelObject modelObject)
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

        //public object InitializeBaseModelObject(object dto)
        //{
        //    if (dto is CategoryBaseDTO)
        //    {
        //        return DTOAdapter<Category, CategoryBaseDTO, CategoryDTO>.InitializeBaseModelObject(dto as CategoryBaseDTO);
        //    }
        //    else if (dto is ProvidedAnswerBaseDTO)
        //    {
        //        return DTOAdapter<ProvidedAnswer, ProvidedAnswerBaseDTO, ProvidedAnswerDTO>.InitializeBaseModelObject(dto as ProvidedAnswerBaseDTO);
        //    }
        //    else if (dto is QuestionBaseDTO)
        //    {
        //        return DTOAdapter<Question, QuestionBaseDTO, QuestionDTO>.InitializeBaseModelObject(dto as QuestionBaseDTO);
        //    }
        //    else if (dto is RatingBaseDTO)
        //    {
        //        return DTOAdapter<Rating, RatingBaseDTO, RatingDTO>.InitializeBaseModelObject(dto as RatingBaseDTO);
        //    }
        //    else if (dto is SolutionBaseDTO)
        //    {
        //        return DTOAdapter<Solution, SolutionBaseDTO, SolutionDTO>.InitializeBaseModelObject(dto as SolutionBaseDTO);
        //    }
        //    else if (dto is TagBaseDTO)
        //    {
        //        return DTOAdapter<Tag, TagBaseDTO, TagDTO>.InitializeBaseModelObject(dto as TagBaseDTO);
        //    }
        //    else if (dto is UserBaseDTO)
        //    {
        //        return DTOAdapter<User, UserBaseDTO, UserDTO>.InitializeBaseModelObject(dto as UserBaseDTO);
        //    }
        //    else
        //    {
        //        // TODO: Log Elmah + add custom exception type
        //        throw new Exception("Type not found");
        //    }
        //}

    }
}
