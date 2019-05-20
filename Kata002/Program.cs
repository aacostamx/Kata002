using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Kata002
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();
            var connectionString = config.GetConnectionString("Kata002Database");
            ScaffoldSql.Run(connectionString);

            using (var context = new Kata002Context(connectionString))
            {
                var posts = context.Posts;
                foreach(var post in posts)
                {
                    Console.WriteLine($"{post.ToString()}");
                    foreach (var comment in post.Comments)
                    {
                        Console.WriteLine($"   {comment.ToString()}");
                    }
                }
            }

        }
    }
}
