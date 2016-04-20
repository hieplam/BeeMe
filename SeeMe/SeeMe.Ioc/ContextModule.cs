using Autofac;
using SeeMe.Repositories;

namespace SeeMe.Ioc
{
    public class ContextModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataContext>().As<DataContext>();
        }
    }
}
