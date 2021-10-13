using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine2
{
    class Abivahend
    {

        public static void Main(string[] arg)
        {

            
            Double a = int.Parse(Console.ReadLine());
            Double b = int.Parse(Console.ReadLine());
            Console.WriteLine(Program.Korruta(3,6));

            Double result = Program.Eval(a.ToString()+"+"+b.ToString());
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
