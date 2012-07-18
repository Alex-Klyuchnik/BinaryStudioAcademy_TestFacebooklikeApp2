using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Models
{
    public class LoginModel:IIdentifiable
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}