using System;
using System.Collections.Generic;
using System.Text;

namespace IssueTracker.Application.Authorization
{
    public interface IAuthorizationService
    {
        void CheckPermission(string permissionName);

        void CheckPermission(string permissionName, string entityId);

        void CheckLogin();
    }
}
