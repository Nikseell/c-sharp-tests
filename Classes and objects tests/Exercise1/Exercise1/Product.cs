using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Product
    {
        private double _price;
        private int _amount;
        private string _name;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
        }

        public int ChangeQuantity(int amount)
        {
            _amount = amount;
            return _amount;
        }

        public double ChangePrice(double price)
        {
            _price = price;
            return _price;
        }

        public string PrintProduct()
        {
            return $"{_name}, price {_price}, amount {_amount}";
        }

    }
}
