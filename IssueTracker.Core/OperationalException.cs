using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Core
{
    public class OperationalException : Exception
    {
        public string Type { get; }

        public OperationalException(string type, string message = null)
            : base(message)
        {
            Type = type;
        }
    }
}
