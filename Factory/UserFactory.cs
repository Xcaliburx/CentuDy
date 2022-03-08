using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Factory
{
    public class UserFactory
    {

        public static User CreateUser(string username, string password, string name, string gender, string phonenumber, string address)
        {
            User user = new User();

            user.RoleId = 2;
            user.Username = username;
            user.Password = password;
            user.Name = name;
            user.Gender = gender;
            user.PhoneNumber = phonenumber;
            user.Address = address;

            return user;
        }

    }
}