using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTO_s;
using MyProject.Services.Interfaces;
using MyProject.WebApi.Models;

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
       
        [HttpGet("{identity}")]
        public async Task<UserDTO> Get(string identity)
        {
            return await _userService.GetByIdAsync(identity);
        }
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel model)
        {
            return await _userService.AddAsync(new UserDTO()
            {
                Birthday = model.Birthday,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = (DTOGender)model.Gender,
                HOM=(DTOHOM)model.HMO,
                Identity=model.Identity
            }) ;
        }
    }
}

