using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.dtos.User;
using back_end.Interfaces;
using back_end.mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace back_end.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null)
                return NotFound();

            return Ok(new
            {
                user.UserID,
                user.Username,
                user.Email
            });
        }
        [HttpPost]

        public async Task<IActionResult> CreateUser([FromBody] User_Create_Dto user_create)
        {
            var usermodel = user_create.ToUserFromCreateDto();
            await _userRepository.CreateUser(usermodel);
            return CreatedAtAction(nameof(GetUserById), new { id = usermodel.UserID }, new
            {
                usermodel.UserID,
                usermodel.Username,
                usermodel.Email
            });
        }
 /*     [Authorize]
      [HttpPut("UpdateEmail")]
      public async Task<IActionResult> UpdateEmail([FromBody] Email_Update_Dto email_update)
      {
        var userName = User.Identity?.Name;
        if(string.IsNullOrEmpty(Username))
        {
          return Unauthorized();

        }
        var user = await _userRepository.GetByUsernameAsync(Username);
        if(user == null)
          return NotFound();
        await _userRepository.UpdateEmailAsync(user, email_update.Email);
        return NoContent();
      }
      */
    }
}
