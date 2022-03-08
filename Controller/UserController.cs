using ProjectFinal.Handler;
using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Controller
{
    public class UserController
    {

        public static User Login(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            User user = UserHandler.Login(username, password);

            if(user == null)
            {
                return null;
            }

            return user;
        }

        public static User findUserById(int userId)
        {
            return UserHandler.findUserbyId(userId);
        }

        public static string Register(string username, string password, string confPassword, string name, string gender, string phonenumber, string address)
        {
            bool checkValid = true;
            string msg = "";

            if (string.IsNullOrEmpty(username))
            {
                msg += "Username cannot be empty \n";
                checkValid = false;
            }
            else if (username.Length < 3)
            {
                msg += "Username length minimal 3 characters \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(password)){
                msg += "Password cannot be empty \n";
                checkValid = false;
            }
            else if (password.Length < 8)
            {
                msg += "Password length minimal 8 characters \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(confPassword))
            {
                msg += "Confirm Password cannot be empty \n";
                checkValid = false;
            }
            else if (confPassword != password)
            {
                msg += "Confirm Password must be the same as the inputted password \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(name))
            {
                msg += "Name cannot be empty \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(gender))
            {
                msg += "Gender cannot be empty \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(phonenumber))
            {
                msg += "Phone Number cannot be empty \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(address))
            {
                msg += "Address cannot be empty \n";
                checkValid = false;
            }
            else if (!address.Contains("Street"))
            {
                msg += "Address must contain the word Street \n";
                checkValid = false;
            }

            if (checkValid == true)
            {
                bool succesRegister = UserHandler.Register(username, password, name, gender, phonenumber, address);

                if (succesRegister == false)
                {
                    msg += "Username must be unique \n";
                    return msg;
                }

                return "Successfully register";

            }
            return msg;
            
        }

        public static string UpdateProfile(string name, string gender, string phone, string address, int userId)
        {
            bool checkValid = true;
            string msg = "";

            if (string.IsNullOrEmpty(name))
            {
                msg += "Name cannot be empty \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(gender))
            {
                msg += "Gender cannot be empty \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(phone))
            {
                msg += "Phone Number cannot be empty \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(address))
            {
                msg += "Address cannot be empty \n";
                checkValid = false;
            }
            else if (!address.Contains("Street"))
            {
                msg += "Address must contain the word Street \n";
                checkValid = false;
            }

            if(checkValid == true)
            {
                bool successUpdate = UserHandler.UpdateProfile(name, gender, phone, address, userId);

                if(successUpdate == false)
                {
                    msg = "Update Failed";
                    return msg;
                }

                return "Successfully Update";
            }

            return msg;
        }

        public static string ChangePassword(string oldPass, string newPass, string confPass, string currPass, int userId)
        {
            bool checkValid = true;
            string msg = "";

            if (string.IsNullOrEmpty(oldPass))
            {
                msg += "Old Password cannot be empty \n";
                checkValid = false;
            }
            else if(oldPass != currPass)
            {
                msg += "Old Password must match with current password \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(newPass))
            {
                msg += "New Password cannot be empty \n";
                checkValid = false;
            }
            else if(newPass.Length < 5)
            {
                msg += "Password length must be longer than 5 characters \n";
                checkValid = false;
            }

            if (string.IsNullOrEmpty(confPass))
            {
                msg += "Confirm Password cannot be empty \n";
                checkValid = false;
            }
            else if(confPass != newPass)
            {
                msg += "Confirm Password must match with new password \n";
                checkValid = false;
            }

            if(checkValid == true)
            {
                bool successChange = UserHandler.ChangePassword(newPass, userId);

                if (successChange == false)
                {
                    msg = "Update Failed";
                    return msg;
                }

                return "Successfully Change Password";
            }

            return msg;
        }
    }
}