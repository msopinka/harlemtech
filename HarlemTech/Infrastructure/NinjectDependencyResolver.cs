using HarlemTech.DataAccess;
using HarlemTech.DataAccess.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace HarlemTech.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            var databaseConnectionString = WebConfigurationManager.ConnectionStrings["HarlemUmbraco"].ConnectionString;
            kernel.Bind<IUmbracoRepository>()
                .To<UmbracoRepository>()
                .WithConstructorArgument(databaseConnectionString);
        }
    }
}