namespace IssueTracker.Core.Issues
{
    public interface IIssueAssignmentConfiguration
    {
        int MaxConcurrentOpenIssueCountForAUser { get; set; }
    }
}
