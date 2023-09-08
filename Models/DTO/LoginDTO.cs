using System.ComponentModel.DataAnnotations;

namespace Assignment_of_projects_and_tasks.Models.DTO{
    public class LoginDTO{
        [Required(ErrorMessage = "Username is required")]
        public string? Username {get; set;}

        [Required(ErrorMessage = "Password is required")]
        public string? Password {get; set;}
    }
}