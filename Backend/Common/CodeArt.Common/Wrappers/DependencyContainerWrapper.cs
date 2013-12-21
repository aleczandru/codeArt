using System;
using CodeArt.Common.Contracts.Wrappers;
using Microsoft.Practices.Unity;

namespace CodeArt.Common.Wrappers
{
    public class DependencyContainerWrapper : IDependencyContainerWrapper
    {

        private IUnityContainer container;
        public IUnityContainer UnityContainer
        {
            get
            {
                return container ?? (container = new UnityContainer());
            }
        }

        public T Resolve<T>()
        {
            return UnityContainer.Resolve<T>();
        }

        public T Resolve<T>(string name)
        {
            return UnityContainer.Resolve<T>(name);
        }

        public void RegisterType<T, TV>() where TV : T
        {
            UnityContainer.RegisterType<T, TV>();
        }

        public void RegisterType(Type from , Type to)
        {
            UnityContainer.RegisterType(from , to);
        }

        public void RegisterSingletonType<T, TV>() where TV : T
        {
            UnityContainer.RegisterType<T, TV>(new ContainerControlledLifetimeManager());
        }
    }
}
