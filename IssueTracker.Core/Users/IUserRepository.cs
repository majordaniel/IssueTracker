namespace IssueTracker.Core.Users
{
    public interface IUserRepository
    {
        User Get(string id);
    }
}
