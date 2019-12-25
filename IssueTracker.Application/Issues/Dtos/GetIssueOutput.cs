using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Application.Issues.Dtos
{
    public class GetIssueOutput
    {
        public IssueDto Issue { get; set; }

        public List<IssueCommentDto> Comments { get; set; }
    }
}
