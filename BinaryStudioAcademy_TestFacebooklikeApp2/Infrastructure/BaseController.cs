using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure
{
    public class BaseController :Controller
    {
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (!string.IsNullOrEmpty(SimpleSessionPersister.Username))
            {
                filterContext.HttpContext.User = 
                    new CustomPrincipal(
                        new CustomIdentity(
                            SimpleSessionPersister.Username));
            }

            base.OnAuthorization(filterContext);
        }
    }

    public static class SimpleSessionPersister
    {
        private static string usernameSessionVar = "username";
        public static string Username
        {
            get
            {
                if (HttpContext.Current == null) return string.Empty;
                var sessionVar =
                    HttpContext.Current.Session[usernameSessionVar];
                if (sessionVar != null)
                {
                    return sessionVar as string;
                }
                return null;
            }
            set { HttpContext.Current.Session[usernameSessionVar] = value; }
        }
    }
}