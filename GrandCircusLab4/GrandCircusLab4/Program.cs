using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab4
{
    class Program
    {
        static void Main()
        {
            string goAgain = "Y";
            Console.WriteLine("Learn your Squares and Cubes!");
            Console.WriteLine("\n");
            ulong num;
            while (goAgain == "Y")
            {
                Console.Write("Please pick a positive integer: ");
                while (!(ulong.TryParse(Console.ReadLine(), out num)) || num < 1)
                {
                    Console.WriteLine("That is not a valid selection. Please pick a positive integer: ");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Number       Squared       Cubed");
                Console.WriteLine("======       =======       =====");
                for (ulong x = 1; x <= num; x++)
                {
                    Console.WriteLine(string.Format("{0,-12} {1,-13} {2,0}", x, x * x, x * x * x));
                }
                Console.WriteLine("\n");
                Console.Write("Again? Y/N: ");
                goAgain = Console.ReadLine().ToUpper();
                if (goAgain == "YES")
                    goAgain = "Y";
                if (goAgain == "NO")
                    goAgain = "N";
                while (goAgain != "Y" && goAgain != "N")
                {
                    Console.WriteLine("Invalid input. Again? Y/N: ");
                    goAgain = Console.ReadLine().ToUpper();
                    if (goAgain == "YES")
                        goAgain = "Y";
                    if (goAgain == "NO")
                        goAgain = "N";
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();

        }
    }
}
