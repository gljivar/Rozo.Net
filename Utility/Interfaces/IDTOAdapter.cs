using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility.Interfaces
{
    public interface IDTOAdapter<MT, DT> 
        where MT : IModelObject where DT : IDTOBase
    {
        DT InitializeDTO(MT modelObject);

        IEnumerable<DT> InitializeDTOs(IEnumerable<MT> modelObjects);
    }
}
