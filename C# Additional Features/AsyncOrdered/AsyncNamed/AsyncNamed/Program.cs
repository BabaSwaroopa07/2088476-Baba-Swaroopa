using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncNamed
{   
    public class Program
    {
        static void Main()

        {
                Batchdetails("ADMFse", "20", "OBL", ".Net", "C# Advanced topics");

                Batchdetails("ADMFse", "20", "OBL", "C# Advanced topics", ".Net");

                Batchdetails(genCCount: "20", cohortName: "ADMFse", mode: "OBL", currentModule: "C# Advanced topics", track: ".Net");



                Console.Read();
        }
            public static void Batchdetails(string cohortName, string genCCount, string mode, string track, string currentModule)
            {
                Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}", cohortName, genCCount, mode, track, currentModule);
            }








        }
    }


