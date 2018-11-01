using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17GC
{
    public class Program
    {
        public static int prime;

        static void Main()
        {
            Console.Write("Let's locate some primes!" +
                "\n\nThis application will find you any prime, in order, from the first prime number on.");

            while(true)
            {
                Console.Write("\nWhich prime number are you looking for?: ");
                while (!int.TryParse(Console.ReadLine(), out prime) || prime < 1)
                {
                    Console.Write("\nInvalid choice. Please enter a whole number greater than 0: ");
                }
                Console.Write($"\nThe {Ordinal(prime)} number in the set of all primes is {PrimeNumberGenerator(prime)}." +
                    $"\n\nDo you want to find another prime number? (y/n): ");
                if(YesNoChecker(Console.ReadLine()) == "y")
                {
                    Console.Clear();
                    continue;
                }
                break;                
            }

            System.Threading.Thread.Sleep(500);
            Console.Write("\nGoodbye");
            System.Threading.Thread.Sleep(2000);
        }

        public static string YesNoChecker(string input)
        {
            while(input != "y" && input != "n")
            {
                Console.Write("\nInvalid input (y/n): ");
                input = Console.ReadLine();
            }
            return input;
        }

        public static int PrimeNumberGenerator(int num)
        {
            int k = 2;
            int j;
            List<int> list = new List<int> { 2 };
            while(list.Count < num)
            {
                k++;
                j = 2;
                while(k % j != 0 && j < k)
                {                    
                    if(k % j == 0)
                    {
                        break;
                    }
                    else if(j == k - 1)
                    {
                        list.Add(k);
                    }
                    j++;
                }
            }
            return list[list.Count - 1];
        }

        public static string Ordinal(int number)
        {
            string suffix;

                switch (number.ToString().Substring(number.ToString().Length -1))
                {
                    case "1":
                        suffix = "st";
                        break;

                    case "2":
                        suffix = "nd";
                        break;

                    case "3":
                        suffix = "rd";
                        break;

                    default:
                        suffix = "th";
                        break;
                }
            return string.Format("{0}{1}", number, suffix);
        }
    }
}
