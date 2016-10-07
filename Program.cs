using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int agevalue;

            try
            {
                //ask for value:
                Console.Write("Enter age: ");
                agevalue = Convert.ToInt32(Console.ReadLine());

                //if else
                if (agevalue > 12 && agevalue < 20)
                {
                    Console.WriteLine("you are teenager.");
                }
                else
                {
                    Console.WriteLine("not a teen.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
