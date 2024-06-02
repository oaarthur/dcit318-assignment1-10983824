using System;

namespace TriangleTypeIdentifier
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Enter Length Of The Base ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Length Of First Side ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Length of Second Side ");
            c = Convert.ToInt32(Console.ReadLine());

            if(c == b && c == a){
                Console.WriteLine("This Is An Equilateral Triangle. All the sides are equal");
            }
            else if(a == b && c != b && c != a){
                Console.WriteLine("This Is An Issoceles Triangle. Only two sides are equal");
            }
            else if(c == b && a != b && a != c){
                Console.WriteLine("This Is An Issoceles Triangle. Only two sides are equal");
            }
            else if(a == c && b != c && b != a){
                Console.WriteLine("This Is An Issoceles Triangle. Only two sides are equal");
            }
            else{
                Console.WriteLine("This Is A Scalene Triangle. All the sides are not equal");
            }
        }
    }
}