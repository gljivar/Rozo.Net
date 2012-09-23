using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rozo.Model;
using Utility.Interfaces;
using Rozo.Model.SpecialCase;
using Rozo.DTO.Adapters;
using Rozo.DTO;

namespace Rozo.Web.Controllers.Api
{
    public class QuestionsController : BaseController<Question, QuestionBaseDTO, QuestionDTO>
    {
        public QuestionsController(IRepository<Question> repository)
            : base(repository)
        {
        }

        //// GET api/question
        //public IEnumerable<QuestionBaseDTO> Get()
        //{
        //    return new QuestionDTOAdapter().InitializeBaseDTOs(repository.GetAll());
        //}

        //// GET api/question/5
        //public QuestionDTO Get(int id)
        //{
        //    var question = repository.GetById(id);
        //    if (question is MissingQuestion)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return new QuestionDTOAdapter().InitializeDTO(question);
        //}

        //// POST api/question
        //public void Post(QuestionDTO question)
        //{
        //}

        //// PUT api/question/5
        //public void Put(int id, QuestionDTO question)
        //{
        //}

        //// DELETE api/question/5
        //public void Delete(int id)
        //{
        //    repository.DeleteById(id);
        //}
    }
}
