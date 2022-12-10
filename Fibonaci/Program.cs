using System;
using System.Collections.Specialized;

namespace Program
{
    class program
    {
        static List<int> fibonaci(List<int> ints)
        {
            if (ints.Count == 20) return ints;
            else ints.Add(ints[ints.Count() - 1] + ints[ints.Count() - 2]); return fibonaci(ints);
        }
        static void Main(string[] arg)
        {
            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(1);
            numbers = fibonaci(numbers);
            foreach (int i in numbers)  
            {
                Console.Write(i + " ");
            }
        }
    }
}

