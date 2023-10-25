using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version2
{
    public class Task3
    {
        class Item
        {
            protected double Price;

            public Item()
            {
                Price = 0;
            }

            public virtual double CalculateTotalPrice()
            {
                return Price;
            }
        }

        class Fruit : Item
        {
            private double _weightInKg;
            private double _priceOfOneKg;

            public double WeightInKg
            {
                get { return _weightInKg; }
                set { _weightInKg = value; }
            }

            public double PriceOfOneKg
            {
                get { return _priceOfOneKg; }
                set { _priceOfOneKg = value; }
            }

            public double CalculateTotalPrice(double weight, double priceOfOneKg)
            {
                _weightInKg = weight;
                _priceOfOneKg = priceOfOneKg;
                Price = _weightInKg * _priceOfOneKg;
                return Price;
            }
        }

        class Electronics : Item
        {
            private int _quantity;
            private double _oneUnitPrice;

            public int Quantity
            {
                get { return _quantity; }
                set { _quantity = value; }
            }

            public double OneUnitPrice
            {
                get { return _oneUnitPrice; }
                set { _oneUnitPrice = value; }
            }

            public override double CalculateTotalPrice()
            {
                Price = _quantity * _oneUnitPrice;
                return Price;
            }
        }

        public void task3()
        {
            Fruit fruit = new Fruit();
            double fruitTotalPrice = fruit.CalculateTotalPrice(5, 2.5);

            Electronics electronics = new Electronics();
            electronics.Quantity = 3;
            electronics.OneUnitPrice = 100.0;
            double electronicsTotalPrice = electronics.CalculateTotalPrice();

            Console.WriteLine("Total Price of Fruit: $" + fruitTotalPrice);
            Console.WriteLine("Total Price of Electronics: $" + electronicsTotalPrice);
        }
    }
}