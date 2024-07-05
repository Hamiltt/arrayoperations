using System;
using System.Drawing;
using System.Net.Http.Headers;

namespace ModsenPractice
{
    class Program
    {
        static int[] numbersArr;
        static void Main()
        {
            string userInput = "";
            int size;
            bool isConverted = false;

            do
            {
                Console.Write("Enter capacity of array: ");
                userInput = Console.ReadLine();
                isConverted = int.TryParse(userInput, out size);
                Console.WriteLine(size);
            } while (isConverted == false || size <= 0);

            var Random = new Random();
            numbersArr = new int[size];

            for (int i = 0; i < numbersArr.Length; i++)
                numbersArr[i] = Random.Next(1, 50);
            ArrayOperations.PrintArray(numbersArr);

            Console.Clear();
            ShowMenu();
        }

        private static void ShowMenu()
        {
            string userChoice;
            do
            {
                ArrayOperations.PrintArray(numbersArr);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Choice operation: \n");
                Console.ResetColor();
                Console.WriteLine("1. Get sum\n2. Get max value\n3. Get previous max value\n4. Get count of unique occurrences\n" +
                    "5. Get first unique entry\n6. Swap min and max values\n7. Swap first and last values\n8.Sort by ascending\n" +
                    "9. Sort by descending\n10. Sort even left, odd - right\n0. Exit");
                userChoice = Console.ReadLine();
                Console.Clear();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Sum of all elements: " + ArrayOperations.GetSum(numbersArr));
                        break;
                    case "2":
                        Console.WriteLine("Max value: " + ArrayOperations.GetMax(numbersArr));
                        break;
                    case "3":
                        Console.WriteLine("Prev max value: " + ArrayOperations.GetPrevMax(numbersArr));
                        break;
                    case "4":
                        Console.WriteLine("Count of unique occurrences: " + ArrayOperations.GetUniqueCount(numbersArr));
                        break;
                    case "5":
                        Console.WriteLine("First unique entry: " + ArrayOperations.GetFirstUnique(numbersArr));
                        break;
                    case "6":
                        ArrayOperations.PrintArray(ArrayOperations.SwapMinMax(numbersArr));
                        break;
                    case "7":
                        ArrayOperations.PrintArray(ArrayOperations.SwapFirstLast(numbersArr));
                        break;
                    case "8":
                        ArrayOperations.PrintArray(ArrayOperations.SortByAscending(numbersArr));
                        break;
                    case "9":
                        ArrayOperations.PrintArray(ArrayOperations.SortByDescending(numbersArr));
                        break;
                    case "10":
                        ArrayOperations.PrintArray(ArrayOperations.SortByEvenOddness(numbersArr));
                        break;
                }
            } while (userChoice != "0");
        }
    }
}
