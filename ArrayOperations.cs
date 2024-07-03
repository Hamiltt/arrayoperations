using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ModsenPractice
{
    public static class ArrayOperations
    {
        public static void PrintArray(int[] numbersArray)
        {
            Console.Write("Your array: ");

            foreach (int number in numbersArray)
                Console.Write($"{number} ");

            Console.WriteLine();
        }

        public static int GetSum(int[] numbersArray)
        {
            int sum = 0;

            foreach (int number in numbersArray)
                sum += number;

            return sum;
        }

        public static int GetMax(int[] numbersArray)
        {
            int maxValue = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > maxValue)
                    maxValue = numbersArray[i];
            }

            return maxValue;
        }

        public static int GetMin(int[] numbersArray)
        {
            int minValue = int.MaxValue;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] < minValue)
                    minValue = numbersArray[i];
            }

            return minValue;
        }

        public static int GetPrevMax(int[] numbersArray)
        {
            int max = 0;
            int prevMax = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > max)
                {
                    prevMax = max;
                    max = numbersArray[i];
                }
                else if (numbersArray[i] < max && numbersArray[i] > prevMax)
                {
                    prevMax = numbersArray[i];
                }
            }

            return prevMax;
        }

        public static int GetUniqueCount(int[] numbersArray)
        {
            var frequency = new Dictionary<int, int>();

            foreach (int number in numbersArray)
            {
                if (frequency.ContainsKey(number))
                    frequency[number]++;
                else
                    frequency[number] = 1;
            }

            return frequency.Count;
        }

        public static int GetFirstUnique(int[] numbersArray)
        {
            var dict = new Dictionary<int, int>();

            foreach (int number in numbersArray)
            {
                if (dict.ContainsKey(number))
                    dict[number]++;
                else
                    dict[number] = 1;
            }

            foreach (KeyValuePair<int, int> pair in dict)
            {
                if (pair.Value == 1)
                    return pair.Key;
            }
            return -1;
        }

        public static int[] SwapMinMax(int[] numbersArray)
        {
            int indexOfMin = 0, indexOfMax = 0;

            for (int i = 1; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > numbersArray[indexOfMax])
                    indexOfMax = i;
                if (numbersArray[i] < numbersArray[indexOfMin])
                    indexOfMin = i;
            }

            (numbersArray[indexOfMin], numbersArray[indexOfMax]) 
                = (numbersArray[indexOfMax], numbersArray[indexOfMin]);

            return numbersArray;
        }

        public static int[] SwapFirstLast(int[] numbersArray)
        {
            (numbersArray[0], numbersArray[numbersArray.Length - 1])
                = (numbersArray[numbersArray.Length - 1], numbersArray[0]);

            return numbersArray;
        }

        public static int[] SortByAscending(int[] numbersArray)
        {
            for (int i = 1; i < numbersArray.Length; i++)
            {
                int current = numbersArray[i];
                int j = i - 1;

                while (j >= 0 && numbersArray[j] > current)
                {
                    numbersArray[j + 1] = numbersArray[j];
                    j--;
                }

                numbersArray[j + 1] = current;
            }

            return numbersArray;
        }

        public static int[] SortByDescending(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                for (int j = 0; j < numbersArray.Length - 1 - i; j++)
                {
                    if (numbersArray[j] < numbersArray[j + 1])
                    {
                        (numbersArray[j + 1], numbersArray[j])
                            = (numbersArray[j], numbersArray[j + 1]);
                    }
                }
            }

            return numbersArray;
        }

        public static int[] SortByEvenOddness(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
                for (int j = 0; j < numbersArray.Length - 1 - i; j++)
                {
                    if (numbersArray[j] % 2 != 0 && numbersArray[j + 1] % 2 == 0)
                    {
                        (numbersArray[j + 1], numbersArray[j])
                            = (numbersArray[j], numbersArray[j + 1]);
                    }
                }
            }

            return numbersArray;
        }
    }
}
