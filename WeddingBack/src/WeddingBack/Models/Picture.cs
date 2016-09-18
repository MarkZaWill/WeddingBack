using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBack.Models
{
    public class Picture
    {
        public byte Picture { get; set; }
        public string TwitterPost { get; set; }
        public string InstaPost { get; set; }
        public int UserId { get; set; }
        public string Tags { get; set; }

    }
}
