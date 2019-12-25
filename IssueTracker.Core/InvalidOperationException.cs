using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Core
{
    public class InvalidOperationException : OperationalException
    {
        public InvalidOperationException(string message)
            : base(OperationalExceptionType.InvalidOperation, message)
        {

        }
    }
}
