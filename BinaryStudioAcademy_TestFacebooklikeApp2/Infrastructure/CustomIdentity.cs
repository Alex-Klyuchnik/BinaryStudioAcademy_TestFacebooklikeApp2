using System.Security.Principal;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure
{
    public class CustomIdentity : IIdentity
    {
        public CustomIdentity(string email)
        {
            this.Name = email;
        }

        public string AuthenticationType
        {
            get { return "Custom"; }
        }

        public bool IsAuthenticated
        {
            get { return !string.IsNullOrEmpty(this.Name); }
        }

        public string Name { get; private set; }
    }

}