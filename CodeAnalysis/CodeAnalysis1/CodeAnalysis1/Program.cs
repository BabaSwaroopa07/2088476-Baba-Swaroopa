using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Baba", "Swaroopa", "Harry", "James", "potter", "Captain", "America" };



            var nameofA = names.Where(n => n.StartsWith("A"));


        }
    }
}
