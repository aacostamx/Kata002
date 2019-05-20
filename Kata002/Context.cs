using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Kata002
{
    public class Kata002Context : DbContext
    {
        private string ConnectionString { get; set; }
        public Kata002Context(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseLazyLoadingProxies().UseSqlServer(ConnectionString);
    }
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public void UpdateBody(string text)
        {
            Body = $"{DateTime.UtcNow}-{text}-{Body}";
        }

        public override string ToString()
        {
            return $"{ID} - {Title} with comment count {Comments.Count}";
        }
    }

    public class Comment
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public string Body { get; set; }
        public virtual Post Post { get; set; }

        public void UpdateBody (string text)
        {
            Body = $"{DateTime.UtcNow}-{text}-{Body}";
        }

        public override string ToString()
        {
            return $"{ID} - {Body} from post {Post.ID}";
        }
    }
}
