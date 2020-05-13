using Guiuiui.Common.Controls;
using Guiuiui.Common.Mvvm;
using Guiuiui.Common.RuntimeChecks;
using System;

namespace Guiuiui.Common.ViewModelInternals
{
    /// <summary>
    /// See <see cref="IPropertyBinding"/>.
    /// </summary>
    internal class PropertyBinding<TPropertyValue> : IPropertyBinding
    {
        private readonly IObservable model;
        private readonly IGet<TPropertyValue> getter;
        private readonly ISet<TPropertyValue> setter;
        private readonly IDataControlAdapter<TPropertyValue> control;

        private bool isBound = false;

        /// <summary>
        /// Used to prevent a stack overflow in case of back coupling due to ill-defined bindings.
        /// </summary>
        private int _callStackDepth = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyBinding{TPropertyValue}"/> class.
        /// </summary>
        public PropertyBinding(
            IObservable model,
            IGet<TPropertyValue> getter,
            ISet<TPropertyValue> setter,
            IDataControlAdapter<TPropertyValue> control)
        {
            ArgumentChecks.AssertNotNull(model, nameof(model));
            ArgumentChecks.AssertNotNull(getter, nameof(getter));
            ArgumentChecks.AssertNotNull(setter, nameof(setter));
            ArgumentChecks.AssertNotNull(control, nameof(control));

            this.model = model;
            this.getter = getter;
            this.setter = setter;
            this.control = control;

            this.model.ValueChanged += this.Model_ValueChanged;
            this.control.ControlValueChanged += this.ControlAdapter_ControlValueChanged;

            this.isBound = true;

            this.InitializeControl();
        }

        /// <summary>
        /// See <see cref="IPropertyBinding.Unbind"/>.
        /// </summary>
        public void Unbind()
        {
            if (this.isBound)
            {
                // Stop observing. This will cause this instance to no longer be referenced via the
                // event handlers, and will eventually allow it to be garbage collected.
                this.model.ValueChanged -= this.Model_ValueChanged;
                this.control.ControlValueChanged -= this.ControlAdapter_ControlValueChanged;

                this.isBound = false;
            }
        }

        private void InitializeControl()
        {
            var modelValue = this.getter.Get();
            this.control.Value = modelValue;
        }

        private void Model_ValueChanged(object sender, EventArgs e)
        {
            // Prevent stack overflow.
            if (this._callStackDepth > 10)
            {
                return;
            }

            // Model value has changed?
            var modelValue = this.getter.Get();
            if (!object.Equals(modelValue, this.control.Value))
            {
                // Update the control.
                this._callStackDepth++;
                this.control.Value = modelValue;
                this._callStackDepth--;
            }
        }

        private void ControlAdapter_ControlValueChanged(object sender, EventArgs e)
        {
            // Prevent stack overflow.
            if (this._callStackDepth > 10)
            {
                return;
            }

            // Control value has changed?
            if (!object.Equals(this.control.Value, this.getter.Get()))
            {
                // Update the model.
                this._callStackDepth++;
                this.setter.Set(this.control.Value);
                this._callStackDepth--;
            }
        }
    }
}
