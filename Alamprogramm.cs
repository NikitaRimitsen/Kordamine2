using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine2
{
    class Alamprogramm
    {

        static void Main(string[] argumendid)
        {
            //Zadanie 4
            Random rnd = new Random();

            int cifra = rnd.Next(1, 10);//переменная для компьютера
            Console.WriteLine("Zagadonoe cislo:");
            int podcet = 1; //счётчик
            int cislo; //переменная для пользователя
            do
            {

                Console.WriteLine($"{podcet} Katse. Mis arv?");
                cislo = int.Parse(Console.ReadLine());
                podcet++;

            } while (podcet!=6 && cifra != cislo);
            if (cislo==cifra)
            {
                Console.WriteLine("Ugadal");
            }
            else
            {
                Console.WriteLine("Ne ugadal");
            }

            //----------------------------------
            //Zadanie 5
            int arv;
            int[] arvud = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Sisesta {0} arv:", i + 1);
                arv = int.Parse(Console.ReadLine());
                arvud[i] = arv;
            }
            Array.Sort(arvud);
            foreach (var a in arvud)
            {
                Console.WriteLine(a);
            }
            int arv4 = 0;
            Array.Reverse(arvud);
            foreach (var a in arvud)
            {
                arv4 = arv4 * 10 + a;

            }
            Console.WriteLine(arv4);

            //----------------------------------
            //Zadanie 6
            int ridadearv = 10, veergudearv = 10;
            if (argumendid.Length == 2)
            {
                ridadearv = int.Parse(argumendid[0]);
                veergudearv = int.Parse(argumendid[1]);
            }
            for (int rida = 1; rida <= ridadearv; rida++)
            {
                for (int veerg = 1; veerg <= veergudearv; veerg++)
                {
                    Console.Write("{0,5}", rida * veerg); //5 kohta
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
