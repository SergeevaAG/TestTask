using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        //Выводится 105, так как стыкуются типы string.

        static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

        class Number
        {
            readonly int _number;

            public Number(int number)
            {
                _number = number;
            }

            public override string ToString()
            {
                return _number.ToString(_ifp);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число someValue1: ");
            int someValue1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число someValue2: ");
            int someValue2 = Convert.ToInt32(Console.ReadLine());

            string result = (someValue1 + someValue2).ToString();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
