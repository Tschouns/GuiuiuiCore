using Guiuiui.Common;
using Guiuiui.Common.TestTypes.Models;
using Guiuiui.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Guiuiui.WinForms.TestApp
{
    /// <summary>
    /// Merely a little test bench for the <see cref="Guiuiui"/> namespace...
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly ViewModel<Person> personViewModel = new ViewModel<Person>();

        public MainForm()
        {
            this.InitializeComponent();
            this.SetupDataBinding();
            this.FillComboBoxes();

            this.personViewModel.Model = this.CreatePersons().First();
        }

        private void SetupDataBinding()
        {
            this.personViewModel
                .BindProperty(p => p.FirstName, (p, v) => p.FirstName = v)
                .ToControl(new TextBoxAdapter<string>(this.firstNameTextBox));

            this.personViewModel
                .BindProperty(p => p.LastName, (p, v) => p.LastName = v)
                .ToControl(new TextBoxAdapter<string>(this.nameTextBox));

            this.personViewModel
                .BindProperty(p => p.LastName, (p, v) => p.LastName = v)
                .ToControl(new TextBoxAdapter<string>(this.nameTextBox));
        }

        private void FillComboBoxes()
        {
            this.genderComboBox.Items.Add(Gender.Male);
            this.genderComboBox.Items.Add(Gender.Female);
        }

        /// <summary>
        /// Just creates some dummy data for demonstration purposes.
        /// </summary>
        private IList<Person> CreatePersons()
        {
            var fritzMeier = new Person
            {
                LastName = "Meier",
                FirstName = "Fritz",
                DateOfBirth = new DateTime(1983, 4, 18),
                Gender = Gender.Male,
                IsVegetarian = true
            };

            var hugoHugentobler = new Person
            {
                LastName = "Hugentobler",
                FirstName = "Hugo",
                DateOfBirth = new DateTime(1971, 11, 2),
                Gender = Gender.Undefined
            };

            var hubertStaffelbach = new Person
            {
                LastName = "Staffelbach",
                FirstName = "Hubert",
                DateOfBirth = new DateTime(1955, 8, 30),
                Gender = Gender.Male
            };

            var gunhildeStaffelbach = new Person
            {
                LastName = "Staffelbach",
                FirstName = "Gunhilde",
                DateOfBirth = new DateTime(1966, 3, 3),
                Gender = Gender.Female
            };

            var persons = new List<Person>
            {
                fritzMeier,
                hugoHugentobler,
                hubertStaffelbach,
                gunhildeStaffelbach
            };

            return persons;
        }
    }
}
