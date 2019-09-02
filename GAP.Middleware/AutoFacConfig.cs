using Autofac;
using Autofac.Integration.WebApi;
using GAP.Dal;
using GAP.Model;
using GAP.Rules;
using System.Reflection;
using System.Web.Http;

namespace GAP.Middleware
{
    public static class AutoFactConfig
    {

        public static HttpConfiguration Configure(HttpConfiguration Configuration, Assembly ApiAssembly)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterApiControllers(ApiAssembly);
            builder.RegisterWebApiFilterProvider(Configuration);

            Rules(ref builder);
            DataAccessLayer(ref builder);
            External(ref builder);

            Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(builder.Build());

            return Configuration;
        }

        /// <summary>
        /// Dependency injection for Inversion of Control
        /// </summary>
        #region Private Methods
        private static void DataAccessLayer(ref ContainerBuilder builder)
        {
            builder.RegisterType<PolicyDal>().As<IPolicyDal>();
            builder.RegisterType<ClientDal>().As<IClientDal>();
        }

        private static void Rules(ref ContainerBuilder builder)
        {
            builder.RegisterType<PolicyRules>().As<IPolicyRules>();
            builder.RegisterType<ClientRules>().As<IClientRules>();
        }

        private static void External(ref ContainerBuilder builder)
        {
            builder.RegisterType<GAPContext>().As<GAPContext>();
        }

        #endregion
    }
}
