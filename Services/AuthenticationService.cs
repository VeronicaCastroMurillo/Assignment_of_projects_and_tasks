using Assignment_of_projects_and_tasks.Models;
using Assignment_of_projects_and_tasks.Models.DTO;
using Assignment_of_projects_and_tasks.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace Assignment_of_projects_and_tasks.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<Application_user> userManager;
        private readonly RoleManager<Application_role> roleManager;

        private readonly SignInManager<Application_user> signInManager;

        public AuthenticationService(UserManager<Application_user> _userManager, RoleManager<Application_role> _roleManager, SignInManager<Application_user> _signInManager)
        {
            userManager = _userManager;
            roleManager = _roleManager;
            signInManager = _signInManager;
        }
        public async Task<StatusDTO> ChangePasswordAsync(ChangePasswordDTO _changePassword, string _userName)
        {
            var status = new StatusDTO();
            var user = await userManager.FindByNameAsync(_userName);

            if (user == null)
            {
                status.Message = "The user does't exist";
                status.StatusCode = 0;
                return status;
            }

            var result = await userManager.ChangePasswordAsync(user, _changePassword.current_password!, _changePassword.New_Password!);
            if (result.Succeeded)
            {
                status.Message = null;
                status.StatusCode = 1;
            }
            else
            {
                status.Message = "Something went wrong";
                status.StatusCode = 0;
            }
            return status;
        }

        public async Task<StatusDTO> LoginAsync(LoginDTO _login)
        {
            var status = new StatusDTO();
            var user = await userManager.FindByNameAsync(_login.Username!);

            if (user == null)
            {
                status.Message = "The user doesn't exist";
                status.StatusCode = 0;
                return status;
            }

            if(!await userManager.CheckPasswordAsync(user, _login.Password!)){
                status.Message = "The password doesn't exist";
                status.StatusCode = 0;
                return status;
            }

            var signInResult = await signInManager.PasswordSignInAsync(user, _login.Password!, false, true);

              if(signInResult.Succeeded){
                    var userRole = await userManager.GetRolesAsync(user);
              }

           }
    }

    public async Task LogoutAsync()
    {
        await signInManager.SignOutAsync();
    }

}
}