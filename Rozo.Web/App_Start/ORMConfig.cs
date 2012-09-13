using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rozo.Web
{
    public class ORMConfig
    {
        public static void RegisterORM()
        {
            System.Data.Entity.Database.SetInitializer(new Rozo.Db.EF.RozoContextInitializer());
        }
    }
}