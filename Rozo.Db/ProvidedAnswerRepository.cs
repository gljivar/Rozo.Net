﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility.Interfaces;
using Rozo.Model;
using System.Data.Entity;
using Rozo.Db.EF;

namespace Rozo.Db
{
    public class ProvidedAnswerRepository : RepositoryBase<ProvidedAnswer>
    {
        public ProvidedAnswerRepository()
            : base(new RozoContext())
        {
        }

    }
}
