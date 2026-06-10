using Schoolify.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.DTOs.Teacher
{
    public class TeacherDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string ForthName { get; set; }
        public Gender Gender { get; set; }
        public DateOnly HireDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        [RegularExpression(
            @"^(?:\+249|0)(?:[1-9][0-9])[0-9]{7}$",
            ErrorMessage = "Invalid Sudan phone number."
        )]
        public string PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string EmailAddress { get; set; }
    }
}
