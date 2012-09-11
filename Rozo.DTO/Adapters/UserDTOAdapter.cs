using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;
using Utility.Interfaces;

namespace Rozo.DTO.Adapters
{
    public class UserDTOAdapter : DTOAdapterBase<User, UserDTO>
    {
        public override UserDTO InitializeDTO(User model)
        {
            var dto = new UserDTO();

            dto.Id = model.Id;
            dto.Name = model.Name;

            return dto;
        }

    }
}
