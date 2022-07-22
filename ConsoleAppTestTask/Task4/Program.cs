using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        /// <summary>
        /// Возвращает отсортированный по возрастанию поток чисел
        /// </summary>
        /// <param name="inputStream">Поток чисел от 0 до maxValue. Длина потока не превышает миллиарда чисел.</param>
        /// <param name="sortFactor">Фактор упорядоченности потока. Неотрицательное число. Если в потоке встретилось число x, то в нём больше не встретятся числа меньше, чем (x - sortFactor).</param>
        /// <param name="maxValue">Максимально возможное значение чисел в потоке. Неотрицательное число, не превышающее 2000.</param>
        /// <returns>Отсортированный по возрастанию поток чисел.</returns>
        static IEnumerable<int> SortA(IEnumerable<int> inputStream, int sortFactor, int maxValue)
        {
            List<int> sortedList = new List<int>();
            sortedList = inputStream.ToList();
            sortedList.Sort();
            List<int> result = new List<int>();
            if (sortedList.Contains(sortFactor))
            {
                foreach (int i in sortedList)
                {
                    if (i <= maxValue & i >= sortFactor) { result.Add(i); }
                }
            }
            else
            {
                foreach (int i in sortedList)
                {
                    if (i > maxValue) { result.Add(i); }
                }
            }

            return result;
        }


        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 6, 2, 5, 4, 3, 1, 10, 7 };
            foreach (int i in SortA(arr, 3, 9)) { Console.Write(i + " "); }
        }
    }
}
