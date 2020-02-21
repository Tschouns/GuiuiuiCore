
namespace Guiuiui.Common.DependencyInjection
{
    /// <summary>
    /// Resolver interface for an IOC container.
    /// </summary>
    public interface IResolve
    {
        /// <summary>
        /// Resolves the implementation for <typeparamref name="TInterface"/> and returns the instance,
        /// or <c>null</c> if it could not be resolved.
        /// </summary>
        TInterface Resolve<TInterface>()
            where TInterface : class;
    }
}
