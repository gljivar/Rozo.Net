using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utility.Interfaces;

namespace Rozo.Web.Controllers.Api
{
    public class BaseController<T> : ApiController where T : class, IModelObject
    {
        protected readonly IRepository<T> repository;

        public BaseController(IRepository<T> repository)
        {
            if (repository == null)
            {
                // TODO: Log exception (ELMAH)??
                throw new ArgumentNullException("Reposotory not set");
            }
            this.repository = repository;
        }
    }
}
