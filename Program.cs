using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine2
{
    class Program
    {
        

        public static int Korruta(int arv1, int arv2)
        {
            return arv1 * arv2;
        }

        public static int Srednee(int number1, int number2)
        {
            return (number1 + number2) / 2;
        }


        public static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }


        static void Main(string[] argumendid)
        {
            int e = 2;
            int c = 5;
            Console.WriteLine("{0} * {1} = {2}", e, c, Korruta(e, c));
            Console.WriteLine(Korruta(3, 6));
            Console.WriteLine("\n");

            Console.WriteLine("({0} + {1}) / 10 = {2}", e, c, Srednee(e, c));
            Console.ReadLine();




            Console.WriteLine("Napishi number 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Napishi number 2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"({a} + {b} / 2) = {Korruta(a,b)}");
            Console.ReadLine();
        }
    }
}
