using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Test
{
    static void Main()
    {
  
            {
            //Greater number output test

            int x;
            int y;
            int greater;
            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);

            //Swap test

            Console.WriteLine("Before swap: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);

            //Factorial function test

            int f;
            bool ok;
            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");
            }
    }
}
