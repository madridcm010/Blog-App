using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.dtos.Comment
{
    public class Comment_Create_Dto
    {
        public required Guid PostId { get; set; }
        public required string content { get; set; }
    }
}