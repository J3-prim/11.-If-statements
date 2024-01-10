using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true; 

            if (isMale) 
            {
                Console.WriteLine("You are male"); 
            }
            else
            {
                Console.WriteLine("You are female");
            }

            bool isTall = false; 
            if (isTall&&isMale) 
            {
                Console.WriteLine("Both male and tall");
            }
            else if (!isTall&&isMale)
            {
                Console.WriteLine("short male");
            } 
            else
            {
                Console.WriteLine("either not tall or female"); 

            }
            Console.Read(); 
        }
    }
}
