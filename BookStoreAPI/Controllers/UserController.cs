using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStore.Repository;
using BookStore.Models.Models;
using BookStore.Models.ViewModels;
namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserRepository repository = new UserRepository();
        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            return Ok(repository.GetUsers());
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginModel model)
        {
            var user = repository.Login(model);
           if(user==null)
            {
                return NotFound();
            }
           else
            {
                return Ok(user);
            }
                
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterModel model)
        {
            User user = repository.addUser(model);
            if (user == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(user);
            }

        }
    }
}
