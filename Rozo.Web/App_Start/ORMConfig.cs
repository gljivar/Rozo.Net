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

            // TODO: Move, just temporary
            try
            {
                new Rozo.Db.EF.RozoContext().Database.ExecuteSqlCommand("alter table Rating add constraint Unique_QuestionSolutionRatedBy unique (Question_Id,Solution_Id,RatedBy_Id)");
            }
            catch
            {
                // TODO: Do not ignore
            }
            
        }
    }
}