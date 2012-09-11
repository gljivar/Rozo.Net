using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;

namespace Rozo.DTO.Adapters
{
    public abstract class DTOAdapterBase<MT, DT> : IDTOAdapter<MT, DT>
    {
        public abstract DT InitializeDTO(MT modelObject);

        public IEnumerable<DT> InitializeDTOs(IEnumerable<MT> modelObjects)
        {
            foreach (var modelObject in modelObjects)
            {
                yield return InitializeDTO(modelObject);
            }
        }
    }
}
