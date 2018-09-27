using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Павлюков Михаил
//14. * Автоморфные числа.Натуральное число называется автоморфным, если оно равно последним цифрам 
//своего квадрата.
//Например, 25 \ :sup: 2 = 625. Напишите программу, которая
//вводит натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            string s = "";
            for (int i = 1; i < N; i++)
            {
                s = (i * i).ToString();
                if (i.ToString() == s[s.Length - 1].ToString())
                {
                    Console.WriteLine(i + " ");
                }
            }
            Console.ReadKey(true);
        }
    }
}
