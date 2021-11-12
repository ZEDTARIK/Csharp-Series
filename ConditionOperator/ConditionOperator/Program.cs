using System;

namespace ConditionOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############################ Condition Operator ###############################");
            
            int Number1, Number2;
            string msg;

            Console.Write("Please Enter the First Number 1 =  " );
            Number1 = int.Parse(Console.ReadLine());

            Console.Write("Please Enter the First Number 2 =  ");
            Number2 = int.Parse(Console.ReadLine());

            // Result Division 

               msg = Number2 == 0 ? "\n Warining, Cannot divide by Zero Please try again !!" : "The Result is = " + Number1 / Number2;

            Console.Write(msg);

            Console.ReadKey();
        }
    }
}
