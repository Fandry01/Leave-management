using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_management.Models
{
    public class EmployeeVM
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        [Display(Name = "Email Adress")]
        public string Email { get; set; }
        [Display(Name = "Phone Nr")]
        public string PhoneNumber { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display (Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Tax ID Number")]
        public string TaxId { get; set; }
        [Display(Name ="Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DateJoined { get; set; }
    }
}
