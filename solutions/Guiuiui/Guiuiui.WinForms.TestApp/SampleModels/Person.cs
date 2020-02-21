using System;
using System.Collections.Generic;

namespace Guiuiui.WinForms.TestApp.SampleModels
{
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public int Age => DateTime.Today.Year - this.DateOfBirth.Year;
        public Gender Gender { get; set; }
        public bool IsVegetarian { get; set; }

        public IList<Address> Addresses { get; } = new List<Address>();

        public string FullName => this.FirstName + " " + this.LastName;
        public string Summary => $"{this.FirstName} {this.LastName} ({this.Gender}, {this.Age})";
    }
}
