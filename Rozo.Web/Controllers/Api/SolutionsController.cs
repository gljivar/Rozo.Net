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
    public class SolutionsController : BaseController<Solution>
    {
        public SolutionsController(IRepository<Solution> repository)
            : base(repository)
        {
        }

        // GET api/category
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/category/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/category
        public void Post([FromBody]string value)
        {
        }

        // PUT api/category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/category/5
        public void Delete(int id)
        {
        }
    }
}
