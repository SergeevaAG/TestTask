using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransformToElephant();
            Console.WriteLine("Муха");
            Console.MoveBufferArea(0, 1, Console.BufferWidth, 1, Console.BufferWidth, 1, ' ', Console.ForegroundColor, Console.BackgroundColor);
        }

        static void TransformToElephant()
        {
            Console.WriteLine("Слон");
        }
    }
}