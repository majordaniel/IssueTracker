using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace IssueTracker.Core.Misc
{
    [DebuggerStepThrough]
    public static class Check
    {        
        public static T NotNull<T>(T value, [NotNull] string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            return value;
        }
    }
}
