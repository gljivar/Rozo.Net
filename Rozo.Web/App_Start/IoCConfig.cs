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

namespace Rozo.Web
{
    public class IoCConfig
    {
        public static void RegisterIoC(HttpConfiguration config)
        {
            var unity = new UnityContainer();
            unity.RegisterType<QuestionController>();
            unity.RegisterType<IRepository<Question>, QuestionRepository>(
                new HierarchicalLifetimeManager());
            config.DependencyResolver = new IoCContainer(unity);
        }
    }
}