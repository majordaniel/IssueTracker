using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Core
{
    public static class OperationalExceptionType
    {
        public const string MaxConcurrentOpenIssueCountForAUser = "MaxConcurrentOpenIssueCountForAUser";
        public const string IssueLocked = "IssueLocked";
        public const string InvalidOperation = "InvalidOperation";
    }
}
