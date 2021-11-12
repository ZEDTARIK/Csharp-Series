using System;

namespace DoWihle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##############  do wihle ###################");

            int repeat = 0;
            do
            {
                Console.WriteLine("Repeat N°  = " + repeat++ );

            } while (repeat > 0 && repeat < 5);


            Console.WriteLine("##############   wihle + goto  ###################");


            ask: Console.WriteLine("WHat's your Name ?  ");
            string name = Console.ReadLine();

            while (name != "zouhair")
             {
                Console.WriteLine("False, try again !!");
                goto ask;
            }
            Console.WriteLine("True your Name is Zouhair");
            Console.ReadKey();
        }
    }
}
