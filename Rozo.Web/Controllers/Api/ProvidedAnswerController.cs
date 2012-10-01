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
    public class ProvidedAnswerController : BaseController<ProvidedAnswer, ProvidedAnswerBaseDTO, ProvidedAnswerDTO>
    {
        public ProvidedAnswerController(IRepository<ProvidedAnswer> repository)
            : base(repository)
        {
        }

    }
}
