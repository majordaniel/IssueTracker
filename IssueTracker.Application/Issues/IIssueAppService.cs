using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Application.Issues
{
    public interface IIssueAppService
    {
        void AssignIssueToUser(AssignIssueToUserInput input);

        void AddComment(AddCommentInput input);

        GetIssueOutput GetIssue(GetIssueInput input);
    }
}
