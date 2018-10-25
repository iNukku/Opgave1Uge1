using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1Uge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthyear;
            int currentyear = Convert.ToInt32(DateTime.Now.Year);

            Console.WriteLine("Please enter your year of birth");
            try
            {
                birthyear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You are " + (currentyear - birthyear) + " years old !!!");
            }
            catch (Exception)
            {
                Console.WriteLine("Woops something went wrong!!!");
            }


            Console.ReadLine();
        }
    }
}
