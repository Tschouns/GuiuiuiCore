
namespace Guiuiui.Common.DependencyInjection
{
    /// <summary>
    /// Represents an IOC container.
    /// </summary>
    public interface IIocContainer
    {
        /// <summary>
        /// Registers the implementation <typeparamref name="TImplementation"/> for
        /// the interface <typeparamref name="TInterface"/>, as a singleton (per thread).
        /// </summary>
        /// <typeparam name="TInterface">
        /// The interface type
        /// </typeparam>
        /// <typeparam name="TImplementation">
        /// The implementation type
        /// </typeparam>
        void RegisterSingleton<TInterface, TImplementation>()
            where TInterface : class
            where TImplementation : TInterface;

        /// <summary>
        /// Resolves the implementation for <typeparamref name="TInterface"/> and returns the instance,
        /// or <c>null</c> if it could not be resolved.
        /// </summary>
        TInterface Resolve<TInterface>()
            where TInterface : class;
    }
}
