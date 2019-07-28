using System;
using System.Collections.Generic;

namespace BLOG_system_ASP.net__MVC_pattern___DOTNETCORE2._2.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Name { get; set; }
        public DateTime Datetime { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }

        public virtual Post Post { get; set; }
    }
}
