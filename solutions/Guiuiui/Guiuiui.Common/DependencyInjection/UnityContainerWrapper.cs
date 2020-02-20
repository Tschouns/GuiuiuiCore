﻿using Guiuiui.Common.RuntimeChecks;
using System;
using Unity;
using Unity.Lifetime;

namespace Guiuiui.Common.DependencyInjection
{
    /// <summary>
    /// Implements <see cref="IIocContainer"/> and wraps a Unity IOC container.
    /// </summary>
    internal class UnityContainerWrapper : IIocContainer, IDisposable
    {
        /// <summary>
        /// Stores the actual Unity IOC container.
        /// </summary>
        private readonly UnityContainer _iocContainer = new UnityContainer();

        /// <summary>
        /// See <see cref="IIocContainer.RegisterSingleton{TInterface, TImplementation}"/>.
        /// </summary>
        public void RegisterSingleton<TInterface, TImplementation>()
            where TInterface : class
            where TImplementation : TInterface
        {
            this._iocContainer.RegisterType<TInterface, TImplementation>(new PerThreadLifetimeManager());
        }

        /// <summary>
        /// See <see cref="IIocContainer.RegisterSingleton"/>.
        /// </summary>
        public void RegisterSingleton(Type interfaceType, Type implementationType)
        {
            ArgumentChecks.AssertNotNull(interfaceType, nameof(interfaceType));
            ArgumentChecks.AssertNotNull(implementationType, nameof(implementationType));

            this._iocContainer.RegisterType(interfaceType, implementationType, new PerThreadLifetimeManager());
        }

        /// <summary>
        /// See <see cref="IIocContainer.Resolve{TInterface}"/>.
        /// </summary>
        public TInterface Resolve<TInterface>() where TInterface : class
        {
            if (!this._iocContainer.IsRegistered<TInterface>())
            {
                return null;
            }

            var instance = this._iocContainer.Resolve<TInterface>();

            return instance;
        }

        /// <summary>
        /// Disposes of the container.
        /// </summary>
        public void Dispose()
        {
            this._iocContainer.Dispose();
        }
    }
}
