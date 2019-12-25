using AutoMapper;

namespace IssueTracker.Infrastructure
{
    public class AutoMapperObjectMapper : Core.Misc.IObjectMapper
    {
        public TDestination Map<TDestination>(object obj)
        {
            return Mapper.Map<TDestination>(obj);
        }
    }
}
