using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utility.Interfaces;
using Rozo.DTO.Adapters;

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
            return DTOAdapter<T, TBaseDTO, TDTO>.InitializeBaseDTOs(repository.GetAll());
        }

        //// GET api/types/5
        public TDTO Get(int id)
        {
            return DTOAdapter<T, TBaseDTO, TDTO>.InitializeDTO(repository.GetById(id));
        }

        // POST api/types
        public HttpResponseMessage Post(TBaseDTO dto)
        {
            var createdDto = DTOAdapter<T, TBaseDTO, TDTO>.InitializeBaseDTO(repository.Create(DTOAdapter<T, TBaseDTO, TDTO>.InitializeBaseModelObject(dto)));
            var response = Request.CreateResponse<TBaseDTO>(HttpStatusCode.Created, createdDto);

            string uri = Url.Link("DefaultApi", new { id = createdDto.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }


        // PUT api/types/5
        public void Put(int id, TBaseDTO dto)
        {
            // TODO: Ask psyburn
            dto.Id = id;
            repository.Update(DTOAdapter<T, TBaseDTO, TDTO>.InitializeBaseModelObject(dto));
        }

        // DELETE api/types/5
        public void Delete(int id)
        {
            repository.DeleteById(id);
        }

    }
}
