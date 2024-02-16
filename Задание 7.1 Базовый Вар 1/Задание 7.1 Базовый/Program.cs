using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._1_Базовый
{
    internal class Program
    {
        public static void Main()
        {
            const int n = 10 + 1;
            char[] arr = new char[n];
            string input = Console.ReadLine();
            Array.Copy(input.ToCharArray(), arr, Math.Min(n, input.Length));

            arr = arr.Select(c => char.IsDigit(c) ? '*' : c).ToArray();

            Console.WriteLine(new string(arr));
        }
    }
}
