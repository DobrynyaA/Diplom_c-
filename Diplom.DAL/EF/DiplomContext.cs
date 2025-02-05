using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom.DAL.Configurations;
using Diplom.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Diplom.DAL.EF
{
    public class DiplomContext : DbContext
    {
        public DiplomContext(DbContextOptions<DiplomContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Follow> Followers { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UsersRoles> UsersRoles { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
        public DbSet<VideoHashtag> VideoHashtags { get; set; }
        public DbSet<View> Views { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FollowConfiguration());
            modelBuilder.ApplyConfiguration(new UserRolesConfiguration());
            modelBuilder.ApplyConfiguration(new VideoHashtagConfiguration());
        }
    }
}
