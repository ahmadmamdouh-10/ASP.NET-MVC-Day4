using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Storage
{
    public class InMemoryUserStorage
    {
        static InMemoryUserStorage()
        {
            Users = new List<User>()
            {
                new User{ID=1, UserName="admin", Password="admin"},
                new User{ID=1, UserName="ahmed", Password="123456"}
            };
        }
        public static List<User> Users
        { get; set; }
    }
}