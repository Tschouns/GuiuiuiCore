
using Guiuiui.Common.DependencyInjection;
using Guiuiui.Common.Parser;
using Guiuiui.Common.Parser.BuiltInTypes;
using Guiuiui.Common.Reflection;
using Guiuiui.Common.RuntimeChecks;
using Guiuiui.Common.TextConverter;

namespace Guiuiui.Common.Setup
{
    /// <summary>
    /// Performs the IOC setup.
    /// </summary>
    public static class IocSetup
    {
        /// <summary>
        /// Registers all implemenations to the specified IOC registry.
        /// </summary>
        public static void DoIocRegistrations<TContainer>(TContainer container)
            where TContainer : class, IRegister, IResolve
        {
            ArgumentChecks.AssertNotNull(container, nameof(container));

            container.RegisterSingleton<ITypeHelper, TypeHelper>();
            container.RegisterSingleton<ITextConverterRegistry, TextConverterRegistry>();
            container.RegisterSingleton<ITextConverterProvider, TextConverterRegistry>();

            // Parser
            container.RegisterSingleton<IParser<bool>, BoolParser>();
            container.RegisterSingleton<IParser<byte>, ByteParser>();
            container.RegisterSingleton<IParser<char>, CharParser>();
            container.RegisterSingleton<IParser<decimal>, DecimalParser>();
            container.RegisterSingleton<IParser<double>, DoubleParser>();
            container.RegisterSingleton<IParser<float>, FloatParser>();
            container.RegisterSingleton<IParser<int>, IntParser>();
            container.RegisterSingleton<IParser<long>, LongParser>();
            container.RegisterSingleton<IParser<sbyte>, SByteParser>();
            container.RegisterSingleton<IParser<short>, ShortParser>();
            container.RegisterSingleton<IParser<string>, StringDummyParser>();
            container.RegisterSingleton<IParser<uint>, UIntParser>();
            container.RegisterSingleton<IParser<ulong>, ULongParser>();
            container.RegisterSingleton<IParser<ushort>, UShortParser>();

            // Parser provider instance
            var parserProvider = new ParserProvider(container);
            container.RegisterInstance<IParserProvider, ParserProvider>(parserProvider);
        }
    }
}
