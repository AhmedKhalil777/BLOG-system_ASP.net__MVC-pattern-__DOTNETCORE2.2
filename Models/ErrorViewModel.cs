using System;

namespace BLOG_system_ASP.net__MVC_pattern___DOTNETCORE2._2.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}