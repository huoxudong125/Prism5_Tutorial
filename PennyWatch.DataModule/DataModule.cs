using System;
using System.Configuration;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using PennyWatch.DataModule.Interfaces;

namespace PennyWatch.DataModule
{
    [Module(ModuleName = "DataModule", OnDemand = false)]
    [ModuleDependency("CommonModule")]
    public class DataModule : IModule
    {
        private IUnityContainer _container;
        public DataModule(IUnityContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterInstance<IDALFacade>(new EFDALFacade(),new ContainerControlledLifetimeManager());
        }
    }
}