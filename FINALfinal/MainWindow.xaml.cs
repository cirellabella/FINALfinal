//Cirella Smith
//6-22-23
//Final
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary;
using CsvHelper;

namespace FINALfinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Initializing the List of accounts
        public static List<UserAccount> accounts = new List<UserAccount>();
        public MainWindow()
        {
            InitializeComponent();
            //preloading the list view with user accounts
            Preload();

        }

        //Preload method to add user accounts to the list
        public void Preload()
        {
            accounts.Add(new UserAccount("Kasey", "ksee23", "fr33styl3", 0));
            accounts.Add(new UserAccount("Cici", "seesee29", "wh@t3v3r", 0));
        }

        //Handling the login button click event and validating that the user account exists 
        // and login info is correct, then opening the user page
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            string userName = tbUsername.Text;
            string password = tbPassword.Text;

            if (ValidateUser(userName, password))
            {
                foreach (UserAccount account in accounts)
                {
                    if (userName == account.UserName)
                    {
                        Data.currentUser = account;
                    }
                }
                new UserPage().Show();
            }
            else
            {
                MessageBox.Show("Please Enter a valid email or password");
            }


            //validate username and password
            //then if valid, check if admin (the role field in the userAccount)
            //or user and open the appropriate page

        }

        //Validating the user account exists within the list of accounts and login is correct
        public bool ValidateUser(string userName, string password)
        {
            foreach (UserAccount account in accounts)
            {
                if (userName == account.UserName && password == account.Password)
                {
                    return true;
                }
            }
            return false;
        }

        //public void ValidateUser()
        //{

        //}

    }
}
