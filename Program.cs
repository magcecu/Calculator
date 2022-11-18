using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mag Calculator Made In C#");
            Console.Write("Num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose from +/-/*/\'/\'");
            string Choose = Console.ReadLine();

            if (Choose == "+")
            {
                int last = (num1 + num2);

                Console.WriteLine(last);
                Console.Write("Press Enter To Continue");
                Console.ReadLine();
            }

            if (Choose == "-")
            {
                int last = (num1 - num2);

                Console.WriteLine(last);
                Console.Write("Press Enter To Continue");
                Console.ReadLine();
            }

            if (Choose == "*")
            {
                int last = (num1 * num2);

                Console.WriteLine(last);
                Console.Write("Press Enter To Continue");
                Console.ReadLine();
            }

            if (Choose == "/")
            {
                int last = (num1 / num2);

                Console.WriteLine(last);
                Console.Write("Press Enter To Continue");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Error!!!");
                Console.Write("Press Enter To Continue");
                Console.ReadLine();
            }
        }
    }
}
