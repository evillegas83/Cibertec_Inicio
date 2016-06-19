using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Employee
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "This first name is required")]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This last name is required")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Display(Name = "Birth Date")]
        [Required(ErrorMessage = "Birth Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Hire Date")]
        [Required(ErrorMessage = "Hire Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

    }
}
