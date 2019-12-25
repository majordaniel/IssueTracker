using IssueTracker.Core.Users;

namespace IssueTracker.Core.Issues.Comments
{
    public class IssueCommentWithCreatorUser
    {
        public IssueComment Comment { get; set; }

        public User CreatorUser { get; set; }
    }
}
