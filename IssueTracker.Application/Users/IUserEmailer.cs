using IssueTracker.Core.Issues;
using IssueTracker.Core.Issues.Comments;
using IssueTracker.Core.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Application.Users
{
    public interface IUserEmailer
    {
        void IssueAssigned(User user, Issue issue);

        void AddedIssueComment(User user, Issue issue, IssueComment comment);
    }
}
