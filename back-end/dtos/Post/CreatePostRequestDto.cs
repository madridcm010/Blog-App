using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.dtos.Post
{
    public class CreatePostRequestDto
    {
        
        public required string Title { get; set; }
        public required string Content { get; set; }
        
    }
}
