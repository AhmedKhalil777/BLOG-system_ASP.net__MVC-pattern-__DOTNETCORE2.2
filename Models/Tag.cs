using System;
using System.Collections.Generic;

namespace BLOG_system_ASP.net__MVC_pattern___DOTNETCORE2._2.Models
{
    public partial class Tag
    {
        public Tag()
        {
            PostTag = new HashSet<PostTag>();
        }

        public int Id { get; set; }
        public string Namw { get; set; }

        public virtual ICollection<PostTag> PostTag { get; set; }
    }
}
