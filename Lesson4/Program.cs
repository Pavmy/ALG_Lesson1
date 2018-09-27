using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Павлюков Михаил
//12. Написать функцию нахождения максимального из трех чисел.

//# include <stdio.h>

//int pred(int a, int b)
//{
//    if (a > b)
//        return a;
//    else
//        return b;
//}

//int max_from_3(int a, int b, int c)
//{
//    return pred(a, pred(b, c));
//}

//int main(void)
//{
//    int x = max_from_3(10, 8, 1);
//    printf("%d", x);
//    return 0;
//}


namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 100;
            int c = 60;
            int max = Math.Max(a, Math.Max(b, c));

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
