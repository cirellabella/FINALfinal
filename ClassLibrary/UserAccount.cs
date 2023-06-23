using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UserAccount
    {
        //public static List<UserAccount> accounts = new List<UserAccount>();
        //fields
        public enum Role { User, Admin }
        string _name;
        string _userName;
        string _password;
        Role _Role;

        public string Name { get => _name; set => _name = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public Role UserRole { get => _Role; set => _Role = value; }

        //constructor
        public UserAccount(string name, string userName, string password, Role role)
        {
            Name = name;
            UserName = userName;
            Password = password;
            _Role = role;
        }

        public UserAccount()
        {

        }

        //Methods
        //public bool IsUser(string userName)
        //{
        //    foreach(UserAccount account in accounts)
        //    {
        //        if(userName == account.UserName)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public bool ValidateUser(string userName, string password)
        //{
        //    foreach (UserAccount account in accounts)
        //    {
        //        if (userName == account.UserName && password == account.Password)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

    }//class
}//namespace
