using Guiuiui.Common.DataBinding;
using Guiuiui.Common.Mvvm;
using Guiuiui.Common.RuntimeChecks;
using Guiuiui.Common.ViewModelInternals;
using System;
using System.Collections.Generic;

namespace Guiuiui.Common
{
    /// <summary>
    /// Represents a view model. Contains the actual data model. Allows to set up data bindings
    /// for controls.
    /// Whenever the contents of the data model are changed by any other client code, the view
    /// model must be notified via <see cref="INotifiable.NotifyValueHasChanged"/>.
    /// </summary>
    /// <typeparam name="TModel">
    /// The type of model managed by this view model
    /// </typeparam>
    public class ViewModel<TModel> : IHaveModel<TModel>, IBindable<TModel>, IObservable, INotifiable
        where TModel : class
    {
        private readonly IList<IPropertyBinding> bindings = new List<IPropertyBinding>();
        private TModel _model = null;

        /// <summary>
        /// See <see cref="IObservable.ValueChanged"/>.
        /// </summary>
        public event EventHandler ValueChanged;

        /// <summary>
        /// See <see cref="IHaveModel{TModel}.Model"/>.
        /// </summary>
        public TModel Model
        {
            get { return this._model; }
            set
            {
                this._model = value;
                this.OnValueChanged();
            }
        }

        /// <summary>
        /// See <see cref="IBindable{TModel}.BindPropertyReadOnly{TPropertyValue}(Func{TModel, TPropertyValue})"/>.
        /// </summary>
        public IBindPredicate<TPropertyValue> BindPropertyReadOnly<TPropertyValue>(Func<TModel, TPropertyValue> getFunc)
        {
            ArgumentChecks.AssertNotNull(getFunc, nameof(getFunc));

            var getter = new ModelGetter<TModel, ViewModel<TModel>, TPropertyValue>(this, getFunc);
            var predicate = new BindReadOnlyPredicate<TModel, TPropertyValue>(this, getter, b => this.bindings.Add(b));

            return predicate;
        }

        /// <summary>
        /// See <see cref="IBindable{TModel}.BindProperty{TPropertyValue}(Func{TModel, TPropertyValue}, Action{TModel, TPropertyValue})"/>.
        /// </summary>
        public IBindPredicate<TPropertyValue> BindProperty<TPropertyValue>(Func<TModel, TPropertyValue> getFunc, Action<TModel, TPropertyValue> setAction)
        {
            ArgumentChecks.AssertNotNull(getFunc, nameof(getFunc));
            ArgumentChecks.AssertNotNull(setAction, nameof(setAction));

            var getter = new ModelGetter<TModel, ViewModel<TModel>, TPropertyValue>(this, getFunc);
            var setter = new ModelSetter<TModel, ViewModel<TModel>, TPropertyValue>(this, setAction);
            var predicate = new BindTwoWayPredicate<TModel, TPropertyValue>(this, getter, setter, this.AddDataBinding);

            return predicate;
        }

        /// <summary>
        /// See <see cref="IBindable{TModel}.BindListProperty{TListItem}(Func{TModel, IEnumerable{TListItem}})"/>.
        /// </summary>
        public IBindListPredicate<TListItem> BindListProperty<TListItem>(Func<TModel, IEnumerable<TListItem>> getFunc)
            where TListItem : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// See <see cref="IBindable{TModel}.UnbindAll"/>.
        /// </summary>
        public void UnbindAll()
        {
            foreach (var dataBinding in this.bindings)
            {
                dataBinding.Unbind();
            }

            this.bindings.Clear();
        }

        /// <summary>
        /// See <see cref="INotifiable.NotifyValueHasChanged"/>.
        /// </summary>
        public void NotifyValueHasChanged()
        {
            this.OnValueChanged();
        }

        /// <summary>
        /// Call-back method, adds a new data binding.
        /// </summary>
        private void AddDataBinding(IPropertyBinding binding)
        {
            ArgumentChecks.AssertNotNull(binding, nameof(binding));

            this.bindings.Add(binding);
        }

        /// <summary>
        /// Raises the <see cref="INotifyOnValueChanged.ValueChanged"/> event.
        /// </summary>
        private void OnValueChanged()
        {
            this.ValueChanged?.Invoke(this, new EventArgs());
        }
    }
}
