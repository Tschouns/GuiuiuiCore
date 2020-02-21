using Guiuiui.Common.DependencyInjection;
using Guiuiui.Common.RuntimeChecks;

namespace Guiuiui.Common.Parser
{
    /// <summary>
    /// See <see cref="IParserProvider"/>.
    /// </summary>
    public class ParserProvider : IParserProvider
    {
        private readonly IResolve container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParserProvider"/> class.
        /// </summary>
        public ParserProvider(IResolve container)
        {
            ArgumentChecks.AssertNotNull(container, nameof(container));

            this.container = container;
        }

        /// <summary>
        /// See <see cref="IParserProvider.GetParser{TResult}"/>.
        /// </summary>
        /// <typeparam name="TResult">
        /// See <see cref="IParserProvider.GetParser{TResult}"/>.
        /// </typeparam>
        public IParser<TResult> GetParser<TResult>()
        {
            var parser = this.container.Resolve<IParser<TResult>>();
            if (parser != null)
            {
                return parser;
            }

            return new DefaultParser<TResult>();
        }
    }
}
