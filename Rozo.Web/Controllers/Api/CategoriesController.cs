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
    public class CategoriesController : BaseController<Category, CategoryBaseDTO, CategoryDTO>
    {
        public CategoriesController(IRepository<Category> repository)
            : base(repository)
        {
        }
    }
}
