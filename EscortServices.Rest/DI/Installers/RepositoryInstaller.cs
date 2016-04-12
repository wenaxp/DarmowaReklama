using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using EscortServices.DataAccess.Repository;
using EscortServices.DataAccess.Model;

namespace EscortServices.Rest.DI.Installers
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<EscortServicesEntities>()
                    .LifestyleTransient(),
                Component.For<IAdvertisementRepository>()
                    .ImplementedBy<AdvertisementRepository>()
                    .LifestyleTransient(),
                Component.For<IParameterRepository>()
                    .ImplementedBy<ParameterRepository>()
                    .LifestyleTransient()
                );
        }


    }
}