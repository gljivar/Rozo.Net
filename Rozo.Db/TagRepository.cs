using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rozo.Model;
using Utility.Interfaces;
using Rozo.Model.SpecialCase;
using Rozo.Db.EF;

namespace Rozo.Db
{
    public class TagRepository : RepositoryBase<Tag>
    {
        public TagRepository()
            : base(new RozoContext())
        {
        }
        
    }
}
