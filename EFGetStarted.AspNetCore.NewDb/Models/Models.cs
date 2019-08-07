using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Models{
    public class BloggingContext : DbContext{
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options){}

        public DbSet<Blog> Blogs{get;set;}
        public DbSet<Post> Posts{get;set;}
    }

    public partial class Blog{
        public int ID{get;set;}
        public string Name{get;set;}

public List<Post> Posts{get;set;}
    }

    public partial class Post{
        public int ID{get;set;}
        public string Title{get;set;}
        public string Content{get;set;}
        public Blog Blog{get;set;}
    }
}