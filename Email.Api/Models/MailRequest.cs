using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Email.Api.Models
{
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Cc { get; set; } = string.Empty;
        public string Bcc { get; set; } = string.Empty;

        public string Subject { get; set; } = string.Empty ;
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }
    }
}
