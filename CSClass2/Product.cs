using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    class Product : IComparable<Product>
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
            /*
            int result = 0;

            if(this.Price < other.Price)result = -1;
            else if(this.Price > other.Price)result = 1;

            return result;
            */
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }
    }
}
