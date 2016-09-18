using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBack.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string UserBio { get; set; }
        public string TwitterHandle { get; set; }
        public string InstagramHandle { get; set; }
    }
}
