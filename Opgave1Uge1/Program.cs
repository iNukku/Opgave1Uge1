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

                if (currentyear-birthyear >= 18)
                {
                    Console.WriteLine("Du er gammel nok!!");
                }
                else
                {
                    Console.WriteLine("Vent et par år!!!");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Woops something went wrong!!!");
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
