using System;
using System.Collections.Generic;

namespace binary_search
{
    class Program
    {
        static object BinarySeachIterative(List<int> list, int key)
        {
            int min = 0;
            int max = list.Count - 1;

            while (min <= max)
            {
                int mid = (max - min) / 2;

                if (list[mid] == key)
                {
                    return mid++;
                } else if (list[mid] > key)
                {
                    min = mid + 1;
                }
                {
                    max = mid - 1;
                }
            }

            return 0;
        }

        static object BinarySeachRecursive(List<int> array, int key, int min, int max)
        {
            return "2";
        }

        static void Main(string[] args)
        {
            var key = 3;
            var collection = new List<int>() { 1, 1, 3, 1, 4, 5, 6, 3, 3, 3 };

            if (args != null && args[0] == "1")
            {
                Console.WriteLine("The key: " + key + " was found in position: " + BinarySeachIterative(collection, key));
            } else if (args[0] == "2")
            {
                Console.WriteLine(BinarySeachRecursive(collection, key, 0, 0));
            }
        }
    }
}
