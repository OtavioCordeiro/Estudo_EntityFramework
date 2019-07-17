using Estudo_EntityFrameworkCore.Data.Interface;
using Estudo_EntityFrameworkCore.Data.Model;
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
        private readonly IUsuarioRepository _userRepository;

        public UserController(IUsuarioRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult List()
        {
            var users = _userRepository.GetAll();

            return new OkObjectResult(users);
        }

        public IActionResult Add()
        {
            UsuarioDAO usuario = new UsuarioDAO()
            {
                Nome = "Maria",
                Email = "Maria@outlook.com"
            };

            _userRepository.Create(usuario);


            return new OkObjectResult("Usuario Criado com sucesso");
        }
    }
}
