namespace IssueTracker.Core.Misc
{
    public interface IObjectMapper
    {
        TDestination Map<TDestination>(object obj);
    }
}
