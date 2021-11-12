using System;
using System.Collections.Generic;
namespace Lymbda_Exp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \n \n ####################  Lymbda  #################### ");

            // Declare array list type string 

            List<string> Colors = new List<string> { "Red", "Bleu", "Orange", "Yellow" };

            Console.WriteLine("The colors are : ");

            Colors.ForEach(item =>
            {
                Console.WriteLine("\t - " + item);
            });

            Console.ReadKey();
        }
    }
}
