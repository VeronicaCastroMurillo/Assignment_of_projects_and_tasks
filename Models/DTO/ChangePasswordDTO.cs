using System.ComponentModel.DataAnnotations;

namespace Assignment_of_projects_and_tasks.Models.DTO{
    public class ChangePasswordDTO{
        [Required(ErrorMessage = "Current Password is required")]
        public string? current_password {get; set;}

        [Required(ErrorMessage = "You must type a new password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage = "Maximum 6 characters, must contain: 1 uppercase, 1 lowercase, 1 special character, and 1 number")]
        public string? New_Password {get; set;}

        [Required(ErrorMessage = "You must confirm the password")]
        [Compare("New_Password", ErrorMessage ="The password doesn't match")]
        public string? Confirm_Password {get; set;}
    }
}