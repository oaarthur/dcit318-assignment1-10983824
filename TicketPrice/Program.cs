using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter Your Age: ");
            a = Convert.ToInt32(Console.ReadLine());

            if(a >= 65 || a <= 12){
                Console.WriteLine("Your Ticket Price Is GHC7");
            }
            else{
                Console.WriteLine("Your Ticket Price Is GHC10");
            }
        }
    }

}