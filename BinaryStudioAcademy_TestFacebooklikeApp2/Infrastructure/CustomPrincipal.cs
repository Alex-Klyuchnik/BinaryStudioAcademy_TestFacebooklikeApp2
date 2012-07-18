using System.Security.Principal;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure
{
    public class CustomPrincipal : IPrincipal
    {
        public CustomPrincipal(CustomIdentity identity)
        {
            this.Identity = identity;
        }

        public IIdentity Identity { get; private set; }

        public bool IsInRole(string role)
        {
            return true;
        }
    }
}