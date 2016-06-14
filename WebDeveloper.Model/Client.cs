using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Client
    {
        public int ID { get; set; }

        [Display(Name ="First Name")]
        [Required(ErrorMessage = "This first name is required")]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This last name is required")]
        public string LastName { get; set; }
    }
}
