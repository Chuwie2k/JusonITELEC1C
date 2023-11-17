using System.ComponentModel.DataAnnotations;

namespace JusonITELEC1C.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "A User Name is Required")]
        public string? UserName { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A Password is Required")]
        public string? Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Confirm your Password")]
        public string? ConfirmPassword { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string? LastName { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is Required")]
        public string? Email { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}")]
        [Required(ErrorMessage = "A Phone Number is Required")]
        public string? Phone { get; set; }

    }
}