
upublic class PostService
{
    private readonly IPostRepository _postRepository;

    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<PostResponseDto> CreatePostAsync(CreatePostRequestDto dto)
    {
        // Manual mapping DTO → Entity
        var post = new Post
        {
            Id = Guid.NewGuid(),
            UserId = dto.UserId,
            Title = dto.Title,
            Content = dto.Content,
            CreatedAt = DateTime.UtcNow
        };

        var savedPost = await _postRepository.AddAsync(post);

        // Manual mapping Entity → Response DTO
        return new PostResponseDto
        {
            Id = savedPost.Id,
            UserId = savedPost.UserId,
            Title = savedPost.Title,
            Content = savedPost.Content,
            CreatedAt = savedPost.CreatedAt
        };
    }
}
