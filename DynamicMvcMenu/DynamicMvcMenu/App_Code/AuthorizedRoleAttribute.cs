using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMvcMenu
{
    public class AuthorizedRoleAttribute : AuthorizeAttribute
    {
        public AuthorizedRoleAttribute(string role)
        {
            Role = role;
        }
        protected override bool AuthorizeCore(HttpContextBase piHttpContext)
        {
            //write actual check here
            return Role == "Admin";
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext piFilterContext)
        {
            base.HandleUnauthorizedRequest(piFilterContext);


        }

        public string Role { get; private set; }
    }
}