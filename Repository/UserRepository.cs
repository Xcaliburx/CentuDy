using ProjectFinal.Factory;
using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Repository
{
    public class UserRepository
    {

        static CentuDYEntities db = new CentuDYEntities();

        public static User Login(string username, string password)
        {
            var query = (from x
                         in db.Users
                         where x.Username == username &&
                         x.Password == password
                         select x);

            User result = query.FirstOrDefault();

            return result;
        }

        public static User findUserById(int userId)
        {
            var query = (from x
                         in db.Users
                         where x.UserId == userId
                         select x);

            User result = query.FirstOrDefault();

            return result;

        }

        //register
        public static User GetUserByUsername(string username)
        {
            var query = (from x
                         in db.Users
                         where x.Username == username
                         select x);

            User result = query.FirstOrDefault();

            return result;
        }

        public static bool Register(string username, string password, string name, string gender, string phonenumber, string address)
        {
            User user = UserFactory.CreateUser(username, password, name, gender, phonenumber, address);

            db.Users.Add(user);
            db.SaveChanges();

            return true;
        }

        public static List<User> GetAllUsers()
        {
            var query = (from x 
                         in db.Users
                         where x.RoleId == 2
                         select x);

            List<User> userList = query.ToList();

            return userList;
        }

        public static User GetUser()
        {
            var query = from x in db.Users where x.UserId == x.UserId select x;
            return (query).FirstOrDefault();
        }

        public static bool UpdateProfile(string name, string gender, string phone, string address, int userId)
        {
            var query = (from x
                         in db.Users
                         where x.UserId == userId
                         select x);

            User result = query.FirstOrDefault();

            result.Name = name;
            result.Gender = gender;
            result.PhoneNumber = phone;
            result.Address = address;
            db.SaveChanges();

            return true;
        }

        public static bool ChangePassword(string password, int userId)
        {
            var query = (from x
                         in db.Users
                         where x.UserId == userId
                         select x);

            User result = query.FirstOrDefault();

            result.Password = password;
            db.SaveChanges();

            return true;
        }

        public static void DeleteUser(int userId)
        {
            var query = (from x
                         in db.Users
                         where x.UserId == userId
                         select x);

            User result = query.FirstOrDefault();

            db.Users.Remove(result);
            db.SaveChanges();
        }
    }
}