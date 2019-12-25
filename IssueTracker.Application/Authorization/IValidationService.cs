using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Application.Authorization
{
    public interface IValidationService
    {
        void Validate(object obj);
    }
}
