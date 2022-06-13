using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class UserLike
    {
        public AppUser SouceUser { get; set; }
        public int SouceUserId { get; set; }
        public AppUser LikedUser { get; set; }
        public int LikedUserId { get; set; }
    }
}