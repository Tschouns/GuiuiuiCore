
namespace Guiuiui.Common.DependencyInjection
{
    /// <summary>
    /// Registry interface for an IOC container.
    /// </summary>
    public interface IRegister
    {
        /// <summary>
        /// Registers the implementation <typeparamref name="TImplementation"/> for
        /// the interface <typeparamref name="TInterface"/>, as a singleton.
        /// </summary>
        /// <typeparam name="TInterface">
        /// The interface for which to specify an implementation
        /// </typeparam>
        /// <typeparam name="TImplementation">
        /// The implementation type
        /// </typeparam>
        void RegisterSingleton<TInterface, TImplementation>()
            where TInterface : class
            where TImplementation : TInterface;

        /// <summary>
        /// Registers a specific instance of type <typeparamref name="TInstance"/>, as singleton
        /// implementation of the interface <typeparamref name="TInterface"/>.
        /// </summary>
        /// <typeparam name="TInterface">
        /// The interface for which to specify an implementation
        /// </typeparam>
        /// <typeparam name="TInstance">
        /// The type of the specified instance, which is an implementation of <typeparamref name="TInterface"/>
        /// </typeparam>
        /// <param name="instance">
        /// The instance to register
        /// </param>
        void RegisterInstance<TInterface, TInstance>(TInstance instance)
            where TInterface : class
            where TInstance : class, TInterface;
    }
}
