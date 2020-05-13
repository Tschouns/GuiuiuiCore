using Guiuiui.Common.Controls;
using Guiuiui.Common.DataBinding;
using Guiuiui.Common.Mvvm;
using Guiuiui.Common.RuntimeChecks;
using System;

namespace Guiuiui.Common.ViewModelInternals
{
    /// <summary>
    /// Implementation of <see cref="IBindPredicate{TPropertyValue}"/>. Creates an actual two-way binding.
    /// </summary>
    /// <typeparam name="TModel">
    /// The model type
    /// </typeparam>
    /// <typeparam name="TPropertyValue">
    /// The property value type
    /// </typeparam>
    internal class BindTwoWayPredicate<TModel, TPropertyValue> : IBindPredicate<TPropertyValue>
        where TModel : class
    {
        // These fields are needed to create the data binding.
        private readonly IObservable model;
        private readonly IGet<TPropertyValue> getter;
        private readonly ISet<TPropertyValue> setter;

        // Call-back used to "return" the new data binding.
        private readonly Action<IPropertyBinding> addDataBindingCallback;

        /// <summary>
        /// Initializes a new instance of the <see cref="BindTwoWayPredicate{TModel,TPropertyValue}"/> class.
        /// </summary>
        public BindTwoWayPredicate(
            IObservable model,
            IGet<TPropertyValue> getter,
            ISet<TPropertyValue> setter,
            Action<IPropertyBinding> addDataBindingCallback)
        {
            ArgumentChecks.AssertNotNull(model, nameof(model));
            ArgumentChecks.AssertNotNull(getter, nameof(getter));
            ArgumentChecks.AssertNotNull(setter, nameof(setter));
            ArgumentChecks.AssertNotNull(addDataBindingCallback, nameof(addDataBindingCallback));

            this.model = model;
            this.getter = getter;
            this.setter = setter;
            this.addDataBindingCallback = addDataBindingCallback;
        }

        /// <summary>
        /// See <see cref="IBindPredicate{TPropertyValue}.ToControl(IDataControlAdapter{TPropertyValue})"/>.
        /// </summary>
        public void ToControl(IDataControlAdapter<TPropertyValue> controlAdapter)
        {
            ArgumentChecks.AssertNotNull(controlAdapter, nameof(controlAdapter));

            var dataBinding = new PropertyBinding<TPropertyValue>(this.model, this.getter, this.setter, controlAdapter);
            this.addDataBindingCallback(dataBinding);
        }
    }
}
