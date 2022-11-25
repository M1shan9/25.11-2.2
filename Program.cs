using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
   Console.WriteLine("Введите любое число: ");
   int n = Convert.ToInt32(Console.ReadLine());
   if (n > 48)
    Console.WriteLine("Ответ: " + (n - 123) * 3);
   else
    Console.WriteLine("Ответ: " + Math.Abs(n - 123));
  }
    }
}
