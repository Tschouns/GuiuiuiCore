
namespace Guiuiui.Common.Mvvm
{
    /// <summary>
    /// Contains the actual data model.
    /// </summary>
    public interface IHaveModel<TModel>
        where TModel : class
    {
        /// <summary>
        /// Gets or sets the actual data model.
        /// </summary>
        TModel Model { get; set; }
    }
}
