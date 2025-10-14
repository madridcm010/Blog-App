using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.dtos.User;
using back_end.Interfaces;
using back_end.mappers;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetUserById(int id)
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

    }
}