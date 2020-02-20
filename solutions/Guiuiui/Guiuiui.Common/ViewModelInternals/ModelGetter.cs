using Guiuiui.Common.Mvvm;
using Guiuiui.Common.RuntimeChecks;
using System;

namespace Guiuiui.Common.ViewModelInternals
{
    /// <summary>
    /// See <see cref="IGet{TPropertyValue}"/>.
    /// </summary>
    public class ModelGetter<TModel, TModelContainer, TPropertyValue> : IGet<TPropertyValue>
        where TModel : class
        where TModelContainer : class, IHaveModel<TModel>
    {
        private readonly TModelContainer modelContainer;
        private readonly Func<TModel, TPropertyValue> getFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelGetter{TModel, TModelContainer, TPropertyValue}"/> class.
        /// </summary>
        public ModelGetter(
            TModelContainer modelContainer,
            Func<TModel, TPropertyValue> getFunc)
        {
            ArgumentChecks.AssertNotNull(modelContainer, nameof(modelContainer));
            ArgumentChecks.AssertNotNull(getFunc, nameof(getFunc));

            this.modelContainer = modelContainer;
            this.getFunc = getFunc;
        }

        /// <summary>
        /// See <see cref="IGet{TPropertyValue}.Get"/>.
        /// </summary>
        public TPropertyValue Get()
        {
            if (this.modelContainer.Model == null)
            {
                return default;
            }

            var value = this.getFunc(this.modelContainer.Model);

            return value;
        }
    }
}
