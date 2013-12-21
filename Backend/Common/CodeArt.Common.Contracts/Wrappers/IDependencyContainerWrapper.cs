using System;

namespace CodeArt.Common.Contracts.Wrappers
{
    public interface IDependencyContainerWrapper
    {
        T Resolve<T>();
        T Resolve<T>(string naame);
        void RegisterType<T, TV>() where TV : T;
        void RegisterType(Type from, Type to);
        void RegisterSingletonType<T, TV>() where TV : T;
    }
}
