using IssueTracker.Core.Users;

namespace IssueTracker.Core.Issues
{
    public interface IIssueAssignmentPolicy
    {
        void CheckAssignment(Issue issue, User user);
    }
}
