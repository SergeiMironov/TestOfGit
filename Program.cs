using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestOfGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number>10)
            {
                Console.WriteLine("Число больше 10");
            }
            else
            {
                Console.WriteLine("число меньше или равно 10");
            }
        }
    }
}
