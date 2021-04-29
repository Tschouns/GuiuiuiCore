using Guiuiui.Common;
using Guiuiui.WinForms.Controls;
using Guiuiui.WinForms.TestApplication.Model;
using System;
using System.Windows.Forms;

namespace Guiuiui.WinForms.TestApplication.Windows
{
    public partial class MainWindow : Form
    {
        private readonly ViewModel<Person> personViewModel = new ViewModel<Person>();

        public MainWindow()
        {
            this.InitializeComponent();

            this.personViewModel.BindProperty(p => p.LastName, (p, v) => p.LastName = v).ToControl(new TextBoxAdapter<string>(this.lastNameTextBox));
            this.personViewModel.BindProperty(p => p.FirstName, (p, v) => p.FirstName = v).ToControl(new TextBoxAdapter<string>(this.firstNameTextBox));
            this.personViewModel.BindProperty(p => p.Gender, (p, v) => p.Gender = v).ToControl(new ComboBoxAdapter<Gender>(this.genderComboBox));
            this.personViewModel.BindProperty(p => p.DateOfBirth, (p, v) => p.DateOfBirth = v).ToControl(new DateTimePickerAdapter(this.dateOfBirthPicker));
            this.personViewModel.BindProperty(p => p.IsVegetarian, (p, v) => p.IsVegetarian = v).ToControl(new CheckBoxAdapter(this.isVegetarianCheckBox));
            this.personViewModel.BindPropertyReadOnly(p => p.FullName).ToControl(new LabelAdapter<string>(this.fullNameOutputLabel));
            this.personViewModel.BindPropertyReadOnly(p => p.Age).ToControl(new LabelAdapter<int>(this.ageOutputLabel));
            
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            this.personViewModel.Model = new Person
            {
                FirstName = "John",
                LastName = "Lennon",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1940, 10, 9),
                IsVegetarian = true,
            };
        }
    }
}
