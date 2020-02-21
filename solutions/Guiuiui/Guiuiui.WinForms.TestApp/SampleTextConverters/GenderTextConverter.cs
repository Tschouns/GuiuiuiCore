
using Guiuiui.Common.TextConverter;
using Guiuiui.WinForms.TestApp.SampleModels;

namespace Guiuiui.WinForms.TestApp.SampleTextConverters
{
    public class GenderTextConverter : ITextConverter<Gender>
    {
        public string GetText(Gender value)
        {
            switch (value)
            {
                case Gender.Male:
                    return "male";
                case Gender.Female:
                    return "female";
                default:
                    return "-";
            }
        }
    }
}
