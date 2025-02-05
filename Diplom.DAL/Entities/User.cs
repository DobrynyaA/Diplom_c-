using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.DAL.Entities
{
    public class User
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string AvatarUrl { get; set; }
        public string Bio { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;

        // Навигационные свойства
        public ICollection<Video> Videos { get; set; }
        public ICollection<Like>? Likes { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Follow>? Followers { get; set; } // Подписчики
        public ICollection<Follow>? Following { get; set; } // Подписки пользователя
        public ICollection<View>? Views { get; set; }
    }
}
