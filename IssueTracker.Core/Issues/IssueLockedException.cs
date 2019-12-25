using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Core.Issues
{
    public class IssueLockedException : OperationalException
    {
        public string IssueId { get; }

        public IssueLockedException(string issueId)
            : base(OperationalExceptionType.IssueLocked)
        {
            IssueId = issueId;
        }
    }
}
