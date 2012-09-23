using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rozo.Model;
using Utility.Interfaces;
using Rozo.DTO;

namespace Rozo.Web.Controllers.Api
{
    public class SolutionsController : BaseController<Solution, SolutionBaseDTO, SolutionDTO>
    {
        public SolutionsController(IRepository<Solution> repository)
            : base(repository)
        {
        }

    }
}
