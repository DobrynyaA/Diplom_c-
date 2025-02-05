﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.DAL.Entities
{
    public class Video
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int Duration { get; set; }
        public int ViewCount { get; set; }
        //навигационные свойства
        public User User { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<VideoHashtag> Hashtags { get; set; }
    }
}
