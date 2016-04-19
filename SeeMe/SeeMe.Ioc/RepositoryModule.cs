using System.Reflection;
using Autofac;
using SeeMe.Repositories;
using SeeMe.Repositories.Interfaces;

namespace SeeMe.Ioc
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("SeeMe.Repositories"))
                .Where(t => t.Name.EndsWith("Repository") && t.Name != "BaseRepository")
                .AsImplementedInterfaces();
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IRepository<>));
        }
    }
}
