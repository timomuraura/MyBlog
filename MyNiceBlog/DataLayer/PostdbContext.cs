using Microsoft.EntityFrameworkCore;
using MyNiceBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNiceBlog.DataLayer
{
    public class PostdbContext : DbContext
    {
        public PostdbContext(DbContextOptions
    <PostdbContext> options) : base(options)
        {
        }
        public DbSet<Post> Post { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Tag> Tag { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>().HasKey(sc => new { sc.TagId, sc.PostId });
        }
    }
}
