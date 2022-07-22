using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal static class Program
    {
        /// <summary>
        /// <para> Отсчитать несколько элементов с конца </para>
        /// <example> new[] {1,2,3,4}.EnumerateFromTail(2) = (1, ), (2, ), (3, 1), (4, 0)</example>
        /// </summary> 
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <param name="tailLength">Сколько элеметнов отсчитать с конца  (у последнего элемента tail = 0)</param>
        /// <returns></returns>
        //public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength) 
        public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
        {
            List<(T item, int? tail)> resDiction = new List<(T item, int? tail)>();
            int position = (int)(enumerable.Count() - (tailLength + 1));
            for (int i = 0; i < enumerable.Count(); i++)
            {
                if (i <= position) { resDiction.Add(new (enumerable.ElementAt(i), null)); }
                else
                {
                    resDiction.Add(new(enumerable.ElementAt(i), tailLength - 1));
                    tailLength--;
                }
            }
            
            return resDiction;
        }


        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 6, 2, 5, 4, 3, 1, 10, 7 };
            EnumerateFromTail(arr, 3).ToList().ForEach(item => Console.Write(item + " "));
        }
    }
}