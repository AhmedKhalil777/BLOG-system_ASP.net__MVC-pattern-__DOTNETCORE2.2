using System;
using System.Collections.Generic;

namespace BLOG_system_ASP.net__MVC_pattern___DOTNETCORE2._2.Models
{
    public partial class Post
    {
        public Post()
        {
            Comment = new HashSet<Comment>();
            PostTag = new HashSet<PostTag>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Datetime { get; set; }
        public string Body { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<PostTag> PostTag { get; set; }
    }
}
