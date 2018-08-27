using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter pet name");
            string pet = Console.ReadLine();
            switch (pet)
            {
                case "dog":
                    Console.WriteLine("yes");
                    break;
                case "cow":
                    Console.WriteLine("yes");
                    break;

                case "rat":
                    Console.WriteLine("no");
                    break;
                default:
                    Console.WriteLine("no idea about animal");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
