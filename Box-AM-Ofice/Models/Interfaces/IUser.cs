using boxAmOffice.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Models.Interfaces
{
    public interface IUser
    {
        public Task<UserDto> Register(Register register, ModelStateDictionary modelstate);
        public Task<UserDto> Login(string username, string password);
        public Task<List<ApplicationUser>> Users();

        public Task Logout();
    }
}
