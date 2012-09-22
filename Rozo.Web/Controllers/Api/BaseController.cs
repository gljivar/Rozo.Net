using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utility.Interfaces;

namespace Rozo.Web.Controllers.Api
{
    public class BaseController<T, TBaseDTO, TDTO> : ApiController 
        where T : class, IModelObject 
        where TBaseDTO : class, IDTOBase
        where TDTO : class, IDTO
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

        //// GET api/types
        public IEnumerable<TBaseDTO> Get()
        {
            return DTO.Adapters.DTOAdapter<T, TBaseDTO, TDTO>.InitializeBaseDTOs(repository.GetAll());
        }

        //// GET api/types/5
        //public TagDTO Get(int id)
        //{
        //    return new TagDTOAdapter().InitializeDTO(repository.GetById(id));
        //}

        //// POST api/types
        //public HttpResponseMessage Post(TagBaseDTO dto)
        //{
        //    var createdDto = new TagDTOAdapter().InitializeBaseDTO(repository.Create(new TagDTOAdapter().InitializeBaseModelObject(dto)));
        //    var response = Request.CreateResponse<TagBaseDTO>(HttpStatusCode.Created, createdDto);

        //    string uri = Url.Link("DefaultApi", new { id = createdDto.Id });
        //    response.Headers.Location = new Uri(uri);
        //    return response;
        //}

        //// PUT api/types/5
        //public void Put(int id, TBaseDTO dto)
        //{
        //    // TODO: Ask psyburn
        //    dto.Id = id;
        //    repository.Update(new TagDTOAdapter().InitializeBaseModelObject(dto));
        //}

        // DELETE api/types/5
        public void Delete(int id)
        {
            repository.DeleteById(id);
        }

    }
}
