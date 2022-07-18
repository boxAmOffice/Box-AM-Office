using Box_AM_Ofice.Models.Interfaces;
using boxAmOffice.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Models.Services
{
    public class UserService : IUser
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> SignInMngr)
        {
            _userManager = userManager;
            _signInManager = SignInMngr;
        }
        public async Task<UserDto> Register(Register register, ModelStateDictionary modelstate)
        {
            var user = new ApplicationUser
            {
                UserName = register.UserName,
                Email = register.EmailAddress
            };

            var result = await _userManager.CreateAsync(user, register.Password);

            if (result.Succeeded)
            {
                // here goes the roles specifications ... 
                return new UserDto
                {
                    Username = user.UserName,
                };
            }
            // // Else, that means there is an error, let us collect all the errors using the modelState
            foreach (var error in result.Errors)
            {
                var errorKey =
                    error.Code.Contains("Password") ? "Password Issue" :
                    error.Code.Contains("Email") ? "Email Issue" :
                    error.Code.Contains("UserName") ? nameof(register.UserName) :
                    "";

                modelstate.AddModelError(errorKey, error.Description);
            }
            return null;

        }


        public async Task<UserDto> Login(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, password, false, false);
                    return new UserDto
                    {
                        Username = user.UserName
                    };
                }
            }
                return null;
        }
        public async Task<List<ApplicationUser>> Users()
        {
            return await _userManager.Users.ToListAsync();
        }
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
    
    }
}
