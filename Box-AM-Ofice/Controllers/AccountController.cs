using Box_AM_Ofice.Models.Interfaces;
using boxAmOffice.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Box_AM_Ofice.Controllers
{
    public class AccountController : Controller
    {
        private IUser _userService;
        public AccountController(IUser userService)
        {
            _userService = userService;

        }
        public async Task<IActionResult> Users()
        {
            var users = await _userService.Users();
            return View(users);
        }
        public IActionResult Login() => View(new Login());

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            if (!ModelState.IsValid) return View(login);

            var user = await _userService.Login(login.UserName, login.Password);
            if(user == null)
            { 
                TempData["Error"] = "Wrong credentials. Please, try again!";
                return View(login);
            }
            return RedirectToAction("Index","Movies");
        }
        public IActionResult Register() {
            return View();
                }

        [HttpPost]
        public async Task<IActionResult> Register(Register register)
        {
            if (!ModelState.IsValid) return View(register);

            var user = await _userService.Register(register, this.ModelState);
            if (user == null)
            {
                TempData["Error"] = "Wrong credentials. Please, try again!";
                return View(register);
            }
            if (ModelState.IsValid)
            {
                return View("RegisterCompleted"); 
            }
            return View(register);
        }
        public async Task<IActionResult> Logout()
        {
            await _userService.Logout();
            return RedirectToAction("Index", "Movies");
        }
    }
}
