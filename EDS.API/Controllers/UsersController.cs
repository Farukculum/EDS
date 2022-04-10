using EDS.Core.DTOs;
using EDS.Service.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EDS.API.Controllers
{
    public class UsersController : BaseController
    {
        private readonly UserService _userService;
        public UsersController()
        {
            _userService = new UserService();
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var users = _userService.All();
            return Ok(CustomResponseDto<List<UserDto>>.Success(users.ToList()));
        }

    }
}
