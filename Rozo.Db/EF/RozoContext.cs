using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Rozo.Model;

namespace Rozo.Db.EF
{
    public class RozoContext : DbContext
    {
        public RozoContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
