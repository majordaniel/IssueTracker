using IssueTracker.Core.Issues.Comments;
using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Core.Issues
{
    public interface IIssueRepository
    {
        Issue Get(string id);

        int GetOpenIssueCountOfUser(string userId);

        void Update(Issue issue);

        List<IssueCommentWithCreatorUser> GetCommentsWithCreatorUsers(string issueId);
    }
}
