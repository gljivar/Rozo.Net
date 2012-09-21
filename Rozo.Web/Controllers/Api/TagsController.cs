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
    public class TagsController : BaseController<Tag>
    {
        public TagsController(IRepository<Tag> repository)
            : base(repository)
        {
        }

        // GET api/tags
        public IEnumerable<TagBaseDTO> Get()
        {
            return new TagDTOAdapter().InitializeBaseDTOs(repository.GetAll());
        }

        // GET api/tags/5
        public TagDTO Get(int id)
        {
            return new TagDTOAdapter().InitializeDTO(repository.GetById(id));
        }

        // POST api/tags
        public void Post(TagBaseDTO dto) //TagBaseDTO dto) //[FromBody]string value)
        {
            repository.Create(new TagDTOAdapter().InitializeBaseModelObject(dto));

            // Set status to 201
            // Put url of resource in header
        }

        // PUT api/tags/5
        public void Put(int id, TagBaseDTO dto)
        {
            // TODO: Ask psyburn
            dto.Id = id;
            repository.Update(new TagDTOAdapter().InitializeBaseModelObject(dto));
        }

        // DELETE api/tags/5
        public void Delete(int id)
        {
            repository.DeleteById(id);
        }
    }
}
