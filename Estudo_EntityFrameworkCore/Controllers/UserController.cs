using Estudo_EntityFrameworkCore.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_EntityFrameworkCore.Controllers
{
    [Route("{Controller}/{Action}")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult List()
        {
            var users = _userRepository.GetAll();

            return new OkObjectResult("Consegui pegar os usuarios");
        }
    }
}
