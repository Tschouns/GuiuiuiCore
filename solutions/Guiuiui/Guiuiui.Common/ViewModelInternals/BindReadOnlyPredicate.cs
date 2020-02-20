using Guiuiui.Common.Controls;
using Guiuiui.Common.DataBinding;
using Guiuiui.Common.Mvvm;
using Guiuiui.Common.Mvvm.ViewModelInternals;
using Guiuiui.Common.RuntimeChecks;
using System;

namespace Guiuiui.Common.ViewModelInternals
{
    /// <summary>
    /// Implementation of <see cref="IBindPredicate{TPropertyValue}"/>. Creates an actual read-only binding.
    /// </summary>
    /// <typeparam name="TModel">
    /// The model type
    /// </typeparam>
    /// <typeparam name="TPropertyValue">
    /// The property value type
    /// </typeparam>
    public class BindReadOnlyPredicate<TModel, TPropertyValue> : IBindPredicate<TPropertyValue>
        where TModel : class
    {
        // These fields are needed to create the data binding.
        private readonly IObservable model;
        private readonly IGet<TPropertyValue> getter;

        // Call-back used to "return" the new data binding.
        private readonly Action<IPropertyBinding> addDataBindingCallback;

        /// <summary>
        /// Initializes a new instance of the <see cref="BindTwoWayPredicate{TModel,TPropertyValue}"/> class.
        /// </summary>
        public BindReadOnlyPredicate(
            IObservable model,
            IGet<TPropertyValue> getter,
            Action<IPropertyBinding> addDataBindingCallback)
        {
            ArgumentChecks.AssertNotNull(model, nameof(model));
            ArgumentChecks.AssertNotNull(getter, nameof(getter));
            ArgumentChecks.AssertNotNull(addDataBindingCallback, nameof(addDataBindingCallback));

            this.model = model;
            this.getter = getter;
            this.addDataBindingCallback = addDataBindingCallback;
        }

        /// <summary>
        /// See <see cref="IBindPredicate{TPropertyValue}.ToControl(IDataControlAdapter{TPropertyValue})"/>.
        /// </summary>
        public void ToControl(IDataControlAdapter<TPropertyValue> controlAdapter)
        {
            ArgumentChecks.AssertNotNull(controlAdapter, nameof(controlAdapter));

            var dummySetter = new DummySetter<TPropertyValue>();
            var dataBinding = new PropertyBinding<TPropertyValue>(this.model, this.getter, dummySetter, controlAdapter);
            this.addDataBindingCallback(dataBinding);
        }
    }
}
