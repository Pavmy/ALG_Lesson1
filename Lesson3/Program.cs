using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Павлюков Михаил
//13. * Написать функцию, генерирующую случайное число от 1 до 100.
//с использованием стандартной функции rand()
//без использования стандартной функции rand()

//На С
//# include <stdio.h>
//# include <stdlib.h>

//int main(void)
//{
//char i;
//     for (i = 1; i <= 50; i++) 
//          {
//          printf("%15d", rand());
//          if (i % 5 == 0) printf("\n");
//          }
//}

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i=0; i<100; i++)
            {
                Console.WriteLine("Ваше случайное число: " + random.Next(100));
                Console.ReadKey();
            }
        }
    }
}
