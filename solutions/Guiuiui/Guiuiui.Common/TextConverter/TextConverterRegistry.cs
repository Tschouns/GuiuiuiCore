using Guiuiui.Common.Reflection;
using Guiuiui.Common.RuntimeChecks;
using System;
using System.Collections.Concurrent;

namespace Guiuiui.Common.TextConverter
{
    /// <summary>
    /// See <see cref="ITextConverterRegistry"/> and <see cref="ITextConverterProvider"/>.
    /// </summary>
    public class TextConverterRegistry : ITextConverterRegistry, ITextConverterProvider
    {
        private readonly ITypeHelper typeHelper;
        private readonly ConcurrentDictionary<Type, object> textConverterDictionary = new ConcurrentDictionary<Type, object>();

        public TextConverterRegistry(ITypeHelper typeHelper)
        {
            ArgumentChecks.AssertNotNull(typeHelper, nameof(typeHelper));

            this.typeHelper = typeHelper;
        }

        /// <summary>
        /// See <see cref="ITextConverterProvider.GetTextConverter{TValue}"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// See <see cref="ITextConverterProvider.GetTextConverter{TValue}"/>.
        /// </typeparam>
        public ITextConverter<TValue> GetTextConverter<TValue>()
        {
            var typePriorities = this.typeHelper.GetInheritedTypes<TValue>();
            foreach (var type in typePriorities)
            {
                if (this.textConverterDictionary.TryGetValue(type, out var textConverter))
                {
                    return (ITextConverter<TValue>)textConverter;
                }
            }

            return new DefaultTextConverter<TValue>();
        }

        /// <summary>
        /// See <see cref="ITextConverterRegistry.RegisterTextConverter{TValue}(ITextConverter{TValue})"/>.
        /// </summary>
        /// <typeparam name="TValue">
        /// See <see cref="ITextConverterRegistry.RegisterTextConverter{TValue}(ITextConverter{TValue})"/>.
        /// </typeparam>
        public void RegisterTextConverter<TValue>(ITextConverter<TValue> textConverter)
        {
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));

            this.textConverterDictionary.AddOrUpdate(typeof(TValue), textConverter, (k, v) => textConverter);
        }
    }
}
