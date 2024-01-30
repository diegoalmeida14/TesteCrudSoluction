using Microsoft.AspNetCore.Mvc;
using TesteCrudData.Repository;
using TesteCrudDomain.Interface;
using TesteCrudModels.Models;

namespace TesteCrudWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        [HttpGet(Name = "GetUsers")]
        public List<UserView> Get()
        {
            return _userService.Get();
        }
        [HttpGet]
        [Route("~/GetById/{id}")]
        public UserView GetById(int id)
        {
            return _userService.GetById(id);
        }

        [HttpGet]
        [Route("~/getbycpf/{cpf}")]
        public UserView GetByCpf(string cpf)
        {
            return _userService.GetByCpf(cpf);
        }

        [HttpPost]
        [Route("~/Create")]
        public void Create(UserView userView)
        {
            _userService.Create(userView);
        }
        [HttpPut]
        [Route("~/Update/{id}")]
        public void Update([FromRoute]int id, [FromBody] UserView userView)
        {
            _userService.Update(id, userView);
        }

        [HttpDelete]
        [Route("~/Delete/{id}")]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }

        [HttpDelete]
        [Route("~/DeleteByCpf/{cpf}")]
        public void DeleteByCpf(string cpf)
        {
            _userService.DeleteByCpf(cpf);
        }

        [HttpPut]
        [Route("~/UpdateByCpf/{cpf}")]
        public void UpdateByCpf([FromRoute] string cpf, [FromBody] UserView userView)
        {
            _userService.UpdateByCpf(cpf, userView);
        }


    }
}
