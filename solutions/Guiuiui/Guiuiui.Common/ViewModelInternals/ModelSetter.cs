using Guiuiui.Common.Mvvm;
using Guiuiui.Common.RuntimeChecks;
using System;

namespace Guiuiui.Common.ViewModelInternals
{
    /// <summary>
    /// See <see cref="ISet{TPropertyValue}"/>.
    /// </summary>
    internal class ModelSetter<TModel, TModelContainer, TPropertyValue> : ISet<TPropertyValue>
        where TModel : class
        where TModelContainer : class, IHaveModel<TModel>, INotifiable
    {
        private readonly TModelContainer modelContainer;
        private readonly Action<TModel, TPropertyValue> setAction;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSetter{TModel, TModelContainer, TPropertyValue}"/> class.
        /// </summary>
        public ModelSetter(
            TModelContainer viewModel,
            Action<TModel, TPropertyValue> setAction)
        {
            ArgumentChecks.AssertNotNull(viewModel, nameof(viewModel));
            ArgumentChecks.AssertNotNull(setAction, nameof(setAction));

            this.modelContainer = viewModel;
            this.setAction = setAction;
        }

        /// <summary>
        /// See <see cref="ISet{TPropertyValue}.Set(TPropertyValue)"/>.
        /// </summary>
        public void Set(TPropertyValue value)
        {
            if (this.modelContainer.Model == null)
            {
                return;
            }

            this.setAction(this.modelContainer.Model, value);
            this.modelContainer.NotifyValueHasChanged();
        }
    }
}
