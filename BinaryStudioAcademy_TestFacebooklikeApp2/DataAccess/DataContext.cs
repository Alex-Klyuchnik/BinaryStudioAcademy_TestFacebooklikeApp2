using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BinaryStudioAcademy_TestFacebooklikeApp2.DataAccess
{
    public class DataContext:DbContext
    {
        public DbSet Account { get; set; }
        public DbSet Login { get; set; }
    }
}