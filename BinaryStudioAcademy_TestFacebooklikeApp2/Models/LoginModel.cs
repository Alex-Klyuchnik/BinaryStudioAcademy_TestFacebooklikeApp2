using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryStudio.ClientManager.DomainModel.Infrastructure;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Models
{
    public class LoginModel:IIdentifiable
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}