
using Guiuiui.Common.TextConverter;
using Guiuiui.WinForms.TestApp.SampleModels;


namespace Guiuiui.WinForms.TestApp.SampleTextConverters
{
    public class AddressTextConverter : ITextConverter<Address>
    {
        public string GetText(Address value)
        {
            if (value == null)
            {
                return "-";
            }

            return $"{value.Street}, {value.PostalCode} {value.City}";
        }
    }
}
