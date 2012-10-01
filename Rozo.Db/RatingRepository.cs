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
    public class RatingRepository : RepositoryBase<Rating>
    {
        public RatingRepository()
            : base(new RozoContext())
        {
        }

    }
}
