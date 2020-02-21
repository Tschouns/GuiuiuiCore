
using Guiuiui.Common.DependencyInjection;
using Guiuiui.Common.Parser;
using Guiuiui.Common.Setup;
using Guiuiui.Common.TextConverter;
using System;

namespace Guiuiui.Common
{
    /// <summary>
    /// Provides tools and helpers for Guiuiui components.
    /// </summary>
    public static class ToolBox
    {
        private static readonly Lazy<IResolve> lazyContainer = new Lazy<IResolve>(SetupIocContainer, isThreadSafe: true);

        /// <summary>
        /// Gets the <see cref="IParserProvider"/>.
        /// </summary>
        public static IParserProvider Parsers => lazyContainer.Value.Resolve<IParserProvider>();

        /// <summary>
        /// Gets the <see cref="ITextConverterProvider"/>.
        /// </summary>
        public static ITextConverterProvider TextConverters => lazyContainer.Value.Resolve<ITextConverterProvider>();

        private static IResolve SetupIocContainer()
        {
            var container = new UnityContainerWrapper();
            IocSetup.DoIocRegistrations(container);

            return container;
        }
    }
}
