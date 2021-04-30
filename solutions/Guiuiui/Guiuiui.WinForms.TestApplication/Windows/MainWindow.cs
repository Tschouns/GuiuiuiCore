using Guiuiui.Common;
using Guiuiui.WinForms.Extensions;
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

            this.personViewModel.BindProperty(p => p.LastName, (p, v) => p.LastName = v).ToTextBox(this.lastNameTextBox);
            this.personViewModel.BindProperty(p => p.FirstName, (p, v) => p.FirstName = v).ToTextBox(this.firstNameTextBox);
            this.personViewModel.BindProperty(p => p.Gender, (p, v) => p.Gender = v).ToComboBox(this.genderComboBox);
            this.personViewModel.BindProperty(p => p.DateOfBirth, (p, v) => p.DateOfBirth = v).ToDateTimePicker(this.dateOfBirthPicker);
            this.personViewModel.BindProperty(p => p.IsVegetarian, (p, v) => p.IsVegetarian = v).ToCheckBox(this.isVegetarianCheckBox);
            this.personViewModel.BindPropertyReadOnly(p => p.FullName).ToLabel(this.fullNameOutputLabel);
            this.personViewModel.BindPropertyReadOnly(p => p.Age).ToLabel(this.ageOutputLabel);
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            this.genderComboBox.Items.AddRange(new object[]
            {
                Gender.Male,
                Gender.Female,
            });

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
