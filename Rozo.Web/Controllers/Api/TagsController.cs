﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rozo.Model;
using Utility.Interfaces;
using Rozo.DTO;
using Rozo.DTO.Adapters;

namespace Rozo.Web.Controllers.Api
{
    public class TagsController : ApiController
    {
        private IRepository<Tag> repository;

        public TagsController(IRepository<Tag> repository)
        {
            if (repository == null)
            {
                // TODO: Log exception (ELMAH)??
                throw new ArgumentNullException("Repository not set");
            }
            this.repository = repository;
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
        public void Post([FromBody]string value)
        {
        }

        // PUT api/tags/5
        public void Put(int id, TagBaseDTO tag)
        {
            
        }

        // DELETE api/tags/5
        public void Delete(int id)
        {
        }
    }
}
