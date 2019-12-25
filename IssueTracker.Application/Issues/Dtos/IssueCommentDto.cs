using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Application.Issues.Dtos
{
    public class IssueCommentDto
    {
        public string Id { get; set; }

        public string Message { get; set; }

        public BasicUserDto CreatorUser { get; set; }
    }
}
