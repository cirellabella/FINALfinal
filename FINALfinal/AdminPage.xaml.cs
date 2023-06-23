using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClassLibrary;

namespace FINALfinal
{
    /// <summary>
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage()
        {
            InitializeComponent();
            PreloadComboBox();
            lblAccount.Content = Data.currentUser.Name;
        }

        //Provided Code - Loads the combo box for selecting a role
        void PreloadComboBox()
        {
            cbRolls.Items.Add("User");
            cbRolls.Items.Add("Admin");
            cbRolls.SelectedIndex = 0;
        }
        //void UpdateLVUser() // Updates List View in AdminWindow

    }//class
}//namespace


//This page is show all the currently registered users, and let you add users with text boxes
//for a name, user name, password, and a combo box to choose if they are an admin or user.
//This is tied to an enumerable in the UserAccount class
