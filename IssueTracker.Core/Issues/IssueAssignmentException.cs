using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Core.Issues
{
    public class IssueAssignmentException : OperationalException
    {
        public IssueAssignmentException(string type, string message)
            : base(type, message)
        {

        }
    }
}
