using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FINALfinal
{
    public static class Data
    {
        public static UserAccount currentUser;
        public static List<UserAccount> accounts = new List<UserAccount>();
        public static string userInformation = "users.json";
        static string TransactionExtension = "_transaction.csv";

        // Use a static constructor to load the accounts list(make sure a file exist before you try to load)
        //static Data()
        //{
        //    ReadUsers();
        //}
        // Special Method with provided code ( helps save a file with the users name and transaction )
        // This creates a unique file automatically based on the user account that's logged in
        public static string UsersTransactions()
        {
            return currentUser.Name + TransactionExtension;
        }
        //public static void Preload() // Used to load accounts list the first time, then save to.json
        //public static void AddUser(UserAccount account) // Add user to accounts and then save to json
        //public static void SaveUsers()
        //{
        //    JsonSerializerOptions jso = new JsonSerializerOptions()
        //    {
        //        WriteIndented = true
        //    };

        //    string jsonManager = JsonSerializer.Serialize(currentUser, jso);

        //    File.WriteAllText(Data.userInformation, jsonManager);
        //} // Save accounts json
        //public static void ReadUsers()
        //{
        //    string filePath = "fileName.json";
        //    string listFromFile = File.ReadAllText(userInformation);
        //    accounts = JsonSerializer.Deserialize<List<UserAccount>>(listFromFile);
        //} // Read json and deserialize to accounts

    }//class
}//namepace
