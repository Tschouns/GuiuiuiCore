using System;

namespace Guiuiui.WinForms.TestApplication.Model
{
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsVegetarian { get; set; }

        public string FullName => $"{this.FirstName} {this.LastName}";
        public int Age => DateTime.Now.Year - this.DateOfBirth.Year;
    }
}
