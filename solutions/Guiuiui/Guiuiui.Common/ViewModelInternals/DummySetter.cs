
namespace Guiuiui.Common.Mvvm.ViewModelInternals
{
    /// <summary>
    /// Dummy implementation of <see cref="ISet{TPropertyValue}"/> -- does not do anything.
    /// </summary>
    public class DummySetter<TPropertyValue> : ISet<TPropertyValue>
    {
        /// <summary>
        /// See <see cref="ISet{TPropertyValue}.Set(TPropertyValue)"/>.
        /// </summary>
        public void Set(TPropertyValue value)
        {
            // Does not do anything.
        }
    }
}
