using Guiuiui.Common.RuntimeChecks;
using System;
using Unity;
using Unity.Lifetime;

namespace Guiuiui.Common.DependencyInjection
{
    /// <summary>
    /// Implements <see cref="IRegister"/> and <see cref="IResolve"/> and wraps a Unity IOC container.
    /// </summary>
    internal class UnityContainerWrapper : IRegister, IResolve, IDisposable
    {
        /// <summary>
        /// Stores the actual Unity IOC container.
        /// </summary>
        private readonly UnityContainer iocContainer = new UnityContainer();

        /// <summary>
        /// See <see cref="IRegister.RegisterSingleton{TInterface, TImplementation}"/>.
        /// </summary>
        public void RegisterSingleton<TInterface, TImplementation>()
            where TInterface : class
            where TImplementation : TInterface
        {
            this.iocContainer.RegisterType<TInterface, TImplementation>(new PerThreadLifetimeManager());
        }

        /// <summary>
        /// See <see cref="IRegister.RegisterInstance{TInterface, TInstance}(TInstance)"/>.
        /// </summary
        void IRegister.RegisterInstance<TInterface, TInstance>(TInstance instance)
        {
            ArgumentChecks.AssertNotNull(instance, nameof(instance));

            this.iocContainer.RegisterInstance<TInterface>(instance);
        }

        /// <summary>
        /// See <see cref="IResolve.Resolve{TInterface}"/>.
        /// </summary>
        public TInterface Resolve<TInterface>() where TInterface : class
        {
            if (!this.iocContainer.IsRegistered<TInterface>())
            {
                return null;
            }

            var instance = this.iocContainer.Resolve<TInterface>();

            return instance;
        }

        /// <summary>
        /// Disposes of the container.
        /// </summary>
        public void Dispose()
        {
            this.iocContainer.Dispose();
        }
    }
}
