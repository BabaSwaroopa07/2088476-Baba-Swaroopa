using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncUsage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The thread");
            MethodOne();
            Console.Read();
        }
        public static async void MethodOne()
        {
            Task<string> task = MethodTwo();
            Console.WriteLine("Waiting for the message from second Method...");
            var result = await task;
            Console.WriteLine(result);
        }
        public static async Task<string> MethodTwo()
        {
            await Task.Delay(5000);
            return "Async and Await is success.";
        }

    }
    
}
