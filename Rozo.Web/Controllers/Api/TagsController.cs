using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rozo.Model;
using Utility.Interfaces;
using Rozo.DTO;
using Rozo.DTO.Adapters;
using Rozo.Db;

namespace Rozo.Web.Controllers.Api
{
    public class TagsController : BaseController<Tag, TagBaseDTO, TagDTO>
    {
        public TagsController(IRepository<Tag> repository)
            : base(repository)
        {
        }

    }
}
