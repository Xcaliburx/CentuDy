using ProjectFinal.Model;
using ProjectFinal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Handler
{
    public class UserHandler
    {

        public static User Login(string username, string password)
        {
            return UserRepository.Login(username, password);
        }

        public static User findUserbyId(int userId)
        {
            return UserRepository.findUserById(userId);
        }
        
        public static bool Register(string username, string password, string name, string gender, string phonenumber, string address)
        {

            User user = UserRepository.GetUserByUsername(username);

            if (user != null)
            {
                return false;
            }

            return UserRepository.Register(username, password, name, gender, phonenumber, address);
        }

        public static List<User> GetAllUsers()
        {
            return UserRepository.GetAllUsers();
        }

        public static User GetUser()
        {
            return UserRepository.GetUser();
        }

        public static bool UpdateProfile(string name, string gender, string phone, string address, int userId)
        {
            return UserRepository.UpdateProfile(name, gender, phone, address, userId);
        }

        public static bool ChangePassword(string password, int userId)
        {
            return UserRepository.ChangePassword(password, userId);
        }

        public static void DeleteUser(int userId)
        {
            UserRepository.DeleteUser(userId);
            return;
        }
    }
}