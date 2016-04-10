using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using AutoMapper;

namespace EscortServices.Rest.DI.Installers
{
    public class AutoMapperInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Types.FromAssemblyInThisApplication()
                    .BasedOn<Profile>()
                    .WithServiceBase()
                    .Configure(c => c.Named(c.Implementation.FullName))
                    .LifestyleTransient());

            var config = new MapperConfiguration(cfg =>
            {
                var profiles = container.ResolveAll<Profile>();
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
            });

            var mapper = config.CreateMapper();

            container.Register(
                Component.For<MapperConfiguration>()
                    .Instance(config)
                    .LifestyleSingleton(),
                Component.For<IMapper>()
                    .Instance(mapper)
                    .LifestyleSingleton()
                );
        }
    }
}