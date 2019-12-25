using IssueTracker.Core.Issues;
using IssueTracker.Core.Issues.Comments;
using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Infrastructure.Issues
{
    public class IssueRepository : IIssueRepository
    {
        public Issue Get(string id)
        {
            throw new NotImplementedException();
        }

        public int GetOpenIssueCountOfUser(string userId)
        {
            throw new NotImplementedException();
        }

        public void Update(Issue issue)
        {
            throw new NotImplementedException();
        }

        public List<IssueCommentWithCreatorUser> GetCommentsWithCreatorUsers(string issueId)
        {
            throw new NotImplementedException();
        }        
    }
}
