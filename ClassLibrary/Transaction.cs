using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Transaction : IComparable<Transaction>
    {
        //fields
        DateTime _transactionTime;
        string _name;
        decimal _price;
        decimal _tax;
        decimal _total;

        public DateTime TransactionTime { get => _transactionTime; set => _transactionTime = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Price { get => _price; set => _price = value; }
        public decimal Tax { get => _tax; set => _tax = value; }
        public decimal Total { get => _total; set => _total = value; }

        //constructors
        public Transaction(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public Transaction()
        {

        }

        //Sort by Name
        public int CompareTo(Transaction? other)
        {
            return this._name.CompareTo(other._name);
            //for names to compare
        }
    }
}
