using System;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.Infrastructure
{
    public class Clock
    {
        public static DateTime? FreezedTime { get; set; }

        public static DateTime Now
        {
            get { return FreezedTime ?? DateTime.Now; }
        }
    }
}