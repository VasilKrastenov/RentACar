using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter First Name")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "EGN \"{0}\" must have {2} character", MinimumLength = 10)]
        public string EGN { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage ="Please enter Email")]
        public string Email { get; set; }

        [DefaultValue(false)]
        public virtual bool IsAdmin { get; set; }
    }
}
