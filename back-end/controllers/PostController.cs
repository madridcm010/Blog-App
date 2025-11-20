using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using back_end.dtos.Post;

namespace back_end.controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
      private readonly IPostRepository _postRepository;
      public PostController(IPostRepository postRepository)
      {
        _postRepository = postRepository;
      }

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] CreatePostRequestDto createPost)
        {
          var postmodel = createPost.CreatePostAsync()
        }

    }
}

