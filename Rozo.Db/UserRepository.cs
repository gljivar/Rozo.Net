using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.Model;
using System.Data.Entity;
using Rozo.Db.EF;

namespace Rozo.Db
{
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository()
            : base(new RozoContext())
        {
        }

        //public UserRepository(DbContext context)
        //    : base(context)
        //{
        //}
    }
}
