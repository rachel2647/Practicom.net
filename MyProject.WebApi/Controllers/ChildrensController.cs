using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTO_s;
using MyProject.Services.Interfaces;
using MyProject.WebApi.Models;

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrensController : ControllerBase
    {
        private readonly IChildrenService _childrenService;
        public ChildrensController(IChildrenService childrenService)
        {
            _childrenService= childrenService;
        }
        [HttpPost]
        public async Task<ChildrenDTO> Post([FromBody] ChildrenModel model)
        {
            return await _childrenService.AddAsync(new ChildrenDTO()
            {
                Birthday = model.Birthday,
                FirstName = model.FirstName,
                Identity = model.Identity,
                IdUser = model.IdParent,
            }) ;
        }
    }
}

