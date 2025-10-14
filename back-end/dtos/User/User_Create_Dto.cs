using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.dtos.User
{
    public class User_Create_Dto
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

    }
}