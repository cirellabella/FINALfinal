using System;
using System.Collections;
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
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Window
    {
        //Initializing the List of transactions
        List<Transaction> transactions = new List<Transaction>();
        public UserPage()
        {
            InitializeComponent();
            //preloading the list view with transactions
            Preload();
            //updating the list view with the transactions in the list
            lvTransactions.ItemsSource = transactions;

            lblUser.Content = Data.currentUser.Name;
        }

        //private void CreateNewFile(string filePath) 
        //    // Used to create a file on load to guarantee a file exists.Use on page load.
        //{
        //    FileStream tryout = File.OpenWrite(filePath);
        //    tryout.Close();
        //    tryout.Dispose();
        //}
        //public void UpdateListView() // Updates the listview
        //public void WriteTransactions(string filePath) 
        //// When called saves transaction list to the users csv
        //public void ReadTransactions() // Loads the users specific csv

        //Preload method to add transactions to the list
        public void Preload()
        {
            transactions.Add(new Transaction("Cat food", 5.80m));
            transactions.Add(new Transaction("Fishing Rod Toy", 15));
        } // Preload()

        //button click events
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //button click to sort by price
        private void btnPrice_Click(object sender, RoutedEventArgs e)
        {
            Transaction_Sort_Price tsp = new Transaction_Sort_Price();
            transactions.Sort(tsp);
            lvTransactions.Items.Refresh();
        }

        //button click to sort by transaction time
        private void btnTransactionTime_Click(object sender, RoutedEventArgs e)
        {
            Transaction_Sort_Time tst = new Transaction_Sort_Time();
            transactions.Sort(tst);
            lvTransactions.Items.Refresh();
        }

        //button click to sort by name
        private void btnName_Click(object sender, RoutedEventArgs e)
        {
            transactions.Sort();
            lvTransactions.Items.Refresh();
        }

        private void btnAddTransaction_Click(object sender, RoutedEventArgs e)
        {

        }
    }//class
}//namespace
