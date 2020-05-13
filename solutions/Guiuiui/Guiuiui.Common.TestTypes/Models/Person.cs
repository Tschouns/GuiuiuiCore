
using System;

namespace Guiuiui.Common.TestTypes.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public bool IsVegetarian { get; set; }
        public decimal AnnualSalary { get; set; }

        public string FullName => $"{this.FirstName} {this.LastName}";
        public string DateOfBirthBigEndian => this.FormatDateBigEndian(this.DateOfBirth);

        private string FormatDateBigEndian(DateTime date)
        {
            var year = this.DateOfBirth.Year.ToString("dd");
            var month = this.DateOfBirth.Month.ToString("dd");
            var day = this.DateOfBirth.Day.ToString("dd");

            var formattedDate = $"{year}/{month}/{day}";

            return formattedDate;
        }
    }
}
