using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            try
            {
                string userInput = Console.ReadLine();
                int number = Convert.ToInt32(userInput);
                Console.WriteLine("You entered: " + number);
            }   
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter a valid numeric value.");
            }
        }
    }
}
