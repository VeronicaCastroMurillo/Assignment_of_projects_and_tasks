using Assignment_of_projects_and_tasks.Models.DTO;

namespace Assignment_of_projects_and_tasks.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<StatusDTO> LoginAsync(LoginDTO _login);
        Task LogoutAsync();

        Task<StatusDTO> ChangePasswordAsync(ChangePasswordDTO _changePassword, string _userName);
    }
}