using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rozo.Model;
using Utility.Interfaces;

namespace Rozo.Web.Controllers.Api
{
    public class QuestionController : ApiController
    {
        private readonly IRepository<Question> repository;

        public QuestionController(IRepository<Question> repository)
        {
            if (repository == null)
            {
                // TODO: Log exception (ELMAH)??
                throw new ArgumentNullException("Reposotory not set");
            }
            this.repository = repository;
        }

        // GET api/question
        public IEnumerable<Question> Get()
        {
            return repository.GetAll();
        }

        // GET api/question/5
        public string Get(int id)
        {
            return "value";

            //var product = products.FirstOrDefault((p) => p.Id == id);
            //if (product == null)
            //{
            //    throw new HttpResponseException(HttpStatusCode.NotFound);
            //}
            //return product;
        }

        // POST api/question
        public void Post([FromBody]string value)
        {
        }

        // PUT api/question/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/question/5
        public void Delete(int id)
        {
        }
    }
}
