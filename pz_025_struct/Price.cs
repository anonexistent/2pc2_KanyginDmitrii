using System;

namespace pz_025_struct
{
    struct Price
    {
        public string tovar;
        public string mag;
        public double price;

        public Price(string a, string b, float c)
        {
            tovar = a;
            mag = b;
            price = c;
        }

        public void GetInfo() => Console.WriteLine("товар: {0} магазин: {1} цена: {2}", tovar, mag, price);
    }
}
