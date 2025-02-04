using Entities.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Services.Contracts{
public interface IAuthService{
    IEnumerable<IdentityRole>Roles { get; }
    IEnumerable<IdentityUser>GetAllUsers();
    Task<UserDtoForUpdate>GetOneUserForUpdate(string username);
    Task<IdentityResult>CreateUser(UserDtoForCreation userDto);
    Task<IdentityUser>GetOneUser(string userName);
    Task Update(UserDtoForUpdate userDto);
    Task<IdentityResult>ResetPassword(ResetPasswordDto model);
    Task<IdentityResult>DeleteOneUser(string username);
}
}