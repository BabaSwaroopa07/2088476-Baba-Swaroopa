using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncOrdered
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orderdetails("ABC", "XYZ", 5, false);
            Orderdetails("ABC", "XYZ");

            Console.Read();
        }

        public static void Orderdetails(string sellerName, string productName, int quantity = 1, bool IsReturnable = true)
        {
            Console.WriteLine("These are the Orderdetails of {0} number of {1} by {2} is ordered. It’s returnable status is {3}", quantity, productName, sellerName, IsReturnable);
        }
    }
}
