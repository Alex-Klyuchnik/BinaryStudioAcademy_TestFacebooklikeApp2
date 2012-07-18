using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryStudioAcademy_TestFacebooklikeApp2.Models;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure
{
    public class AddFriend
    {

        private static void Add(AccountModel friend, AccountModel user)
            {
                user.Friends.Add(friend);
            }

        public void Delete(AccountModel friend, AccountModel user)
            {
                user.Friends.Remove(friend);
            }

        public void SendRequest(AccountModel friend, AccountModel user)
            {
                friend.RequestedFriendship.Add(user);
            }

        public void AcceptRequest(AccountModel friend, AccountModel user)
            {
                Add(friend, user);
                Add(user, friend);
                user.RequestedFriendship.Remove(friend);
            }

        public void DeclineRequest(AccountModel friend, AccountModel user)
            {
                user.RequestedFriendship.Remove(friend);
            }
        
    }
}