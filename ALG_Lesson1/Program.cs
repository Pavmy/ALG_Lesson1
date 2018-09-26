using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Павлюков Михаил
////3. Написать программу обмена значениями двух целочисленных переменных:
//a.с использованием третьей переменной;
//b. * без использования третьей переменной.


namespace ALG_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;

            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;

            Console.WriteLine("a = "+ a + " b = "+ b);
            Console.ReadKey();
        }
    }
}
