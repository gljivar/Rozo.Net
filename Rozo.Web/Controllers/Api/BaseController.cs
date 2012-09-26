using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utility.Interfaces;
using Rozo.DTO.Adapters;
using Rozo.Web.Helpers;

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

        // GET api/types
        public Rozo.Web.Helpers.ResultWrapper<TBaseDTO> Get(int offset = 0, int limit = 10)
        {
            // Offset is by default 0 and can't be negative
            offset = offset <= 0 ? 0 : offset;
            // limit is default 10 and can't be negative
            limit = limit <= 0 ? 10 : limit;

            // TODO: Implement OrderBy and filtering
            var data = DTOAdapter<T, TBaseDTO, TDTO>.InitializeBaseDTOs(
                repository.GetAll().Skip(offset).Take(limit)
                );

            var pagination = PaginationHelper.CreatePagination(Url, offset, limit, repository.Count());

            return new Rozo.Web.Helpers.ResultWrapper<TBaseDTO>(data, pagination);
        }

        // GET api/types/5
        public HttpResponseMessage Get(int id)
        {
            var data = repository.GetById(id);

            if (data is IMissingModelObject)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not found.");
            }
            else
            {
                return Request.CreateResponse<TDTO>(
                    HttpStatusCode.OK, 
                    DTOAdapter<T, TBaseDTO, TDTO>.InitializeDTO(data)
                    );
            }
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
            // TODO: Fix DTO to model mapping
            repository.Update(id, DTOAdapter<T, TBaseDTO, TDTO>.InitializeBaseModelObject(dto));
        }

        // DELETE api/types/5
        public void Delete(int id)
        {
            repository.DeleteById(id);
        }

    }
}
