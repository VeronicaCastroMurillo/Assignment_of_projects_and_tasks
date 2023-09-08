using Assignment_of_projects_and_tasks.Models;
using Assignment_of_projects_and_tasks.Models.DTO;
using Assignment_of_projects_and_tasks.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Assignment_of_projects_and_tasks.Services{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<Application_user> userManager;
        private readonly RoleManager<Application_role> roleManager;

        private readonly SignInManager<Application_user> signInManager;

        public AuthenticationService(UserManager<Application_user> _userManager,RoleManager<Application_role> _roleManager,SignInManager<Application_user> _signInManager){
            userManager = _userManager;
            roleManager = _roleManager;
            signInManager = _signInManager;
        }
        public Task<StatusDTO> ChangePasswordAsync(ChangePasswordDTO _changePassword, string _userName)
        {
            throw new NotImplementedException();
        }

        public Task<StatusDTO> LoginAsync(LoginDTO _login)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}