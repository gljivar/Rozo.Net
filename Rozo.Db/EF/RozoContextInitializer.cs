﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Rozo.Model;

namespace Rozo.Db.EF
{
    public class RozoContextInitializer : DropCreateDatabaseIfModelChanges<RozoContext>
    {
        protected override void Seed(RozoContext context)
        {
            var tags = new List<Tag>() 
            { 
                new Tag() { Name = "Matematika 1" }, 
                new Tag() { Name = "Fizika 1" }, 
                new Tag() { Name = "Osnove elektrotehnike"},
                new Tag() { Name = "Programiranje i programsko inženjerstvo" } 

                //new Tag() { Id = 0, Name = "Matematika 1", Questions = new List<Question>() }, 
                //new Tag() { Id = 1, Name = "Fizika 1", Questions = new List<Question>() }, 
                //new Tag() { Id = 2, Name = "Osnove elektrotehnike", Questions = new List<Question>() },
                //new Tag() { Id = 3, Name = "Programiranje i programsko inženjerstvo", Questions = new List<Question>() } 
            };

            tags.ForEach(t => context.Tags.Add(t));
            context.SaveChanges();
        }
    }
}