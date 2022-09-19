using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMeets.Core.Common.DTO.Email.EmailTemplate
{
    public class MeetingConfirmationEmailDto
    {
        public string Name { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string LocationType { get; set; } = null!;
        public string AuthorName { get; set; } = null!;
        public string AuthorEmail { get; set; } = null!;
        public string MeetingLink { get; set; } = null!;
    }
}
