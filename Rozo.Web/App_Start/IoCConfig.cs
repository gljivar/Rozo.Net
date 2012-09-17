using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.Practices.Unity;
using Rozo.Web.Controllers.Api;
using Rozo.Model;
using Utility.Interfaces;
using Rozo.Db;
using Rozo.Web.Helpers.IoC;
using System.Data.Entity;

namespace Rozo.Web
{
    public class IoCConfig
    {
        public static void RegisterIoC(HttpConfiguration config)
        {
            var unity = new UnityContainer();

            RegisterTypes(unity);
            
            config.DependencyResolver = new IoCContainer(unity);
        }

        private static void RegisterTypes(IUnityContainer unity)
        {
            // Questions
            unity.RegisterType<QuestionsController>();
            unity.RegisterType<IRepository<Question>, QuestionRepository>(
                new HierarchicalLifetimeManager());

            // Tags
            unity.RegisterType<TagsController>();
            unity.RegisterType<IRepository<Tag>, TagRepository>(
                new HierarchicalLifetimeManager());

            // DbContext
            //unity.RegisterType<Db.RepositoryBase<Tag>>();
            //unity.RegisterType<DbContext, Db.EF.RozoContext>(
            //    new HierarchicalLifetimeManager());

        }

    }
}