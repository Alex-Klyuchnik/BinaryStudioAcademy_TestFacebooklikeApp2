using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryStudio.ClientManager.DomainModel.Infrastructure;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Models
{
    public class AccountModel:IIdentifiable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsIdentified { get; set; }
    }
}