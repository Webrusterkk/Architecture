using Autofac;

using Architecture.Web.References;
using Architecture.Core.Services;
using Architecture.Services.Services;

namespace Architecture.Web.Capsule.Modules
{
    public class ServiceCapsuleModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ReferencedAssemblies.Services).
                Where(_ => _.Name.EndsWith("Service")).
                AsImplementedInterfaces().
                InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(BaseService<>)).As(typeof(IService<>)).InstancePerDependency();
        }

    }
}