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
            // Tags
            unity.RegisterType<TagsController>();
            unity.RegisterType<IRepository<Tag>, TagRepository>(
                new HierarchicalLifetimeManager());

            // Categories
            unity.RegisterType<CategoriesController>();
            unity.RegisterType<IRepository<Category>, CategoryRepository>(
                new HierarchicalLifetimeManager());

            // Users
            unity.RegisterType<UsersController>();
            unity.RegisterType<IRepository<User>, UserRepository>(
                new HierarchicalLifetimeManager());

            // Questions
            unity.RegisterType<QuestionsController>();
            unity.RegisterType<IRepository<Question>, QuestionRepository>(
                new HierarchicalLifetimeManager());

            // Solutions
            unity.RegisterType<SolutionsController>();
            unity.RegisterType<IRepository<Solution>, SolutionRepository>(
                new HierarchicalLifetimeManager());

            // Ratings
            // No

            // ProvidedAnswers
            // No
            

        }

    }
}