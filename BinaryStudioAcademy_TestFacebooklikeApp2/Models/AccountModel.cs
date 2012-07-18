using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Models
{
    public class AccountModel:IIdentifiable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsIdentified { get; set; }
        public LoginModel Login { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        public ICollection<string> Interests { get; set; }
        public ICollection<AccountModel> Friends { get; set; }
        public ICollection<AccountModel> RequestedFriendship { get; set; } 
    }
}