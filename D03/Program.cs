

using System;
using System.Collections.Generic;

namespace D03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* #region Identity Matrix
            {
                IdentityMatrex(3);
            }
            #endregion

            #region calculationSalaries
            float[] Salaries = new float[5];
            GetArrayFromUser(ref Salaries);
            AddBouns(ref Salaries);
            PrintSalaries(Salaries);
            #endregion

            #region factorialFuntion
            {
            int  n = 5;
                factorialFunction(n); 
            }
            #endregion


            #region Identical2Arrays
            {
                int[] arr1 = { 1, 2, 3, 4, 5 };
                int[] arr2 = { 1, 2, 3, 4, 5 };

                Console.WriteLine("the result is "+Identical2Arrays(arr1, arr2));
                int[] arr3 = { 1, 2, 3, 4, 6 };
                Console.WriteLine("the result is " + Identical2Arrays(arr1, arr3));
            }

            #endregion

            #region 
            #endregion

            #region ReversedSentence
            {
                string sentence = "this is a test";
                string reversedSentence = ReverseWordsInSentence(sentence);
                Console.WriteLine(reversedSentence);
            }
            #endregion*/

            #region ShiftArrayLeft
            int[] arr =new int[5] { 10, 20, 30, 40, 50 };
            ShiftArrayLeft(arr);
            #endregion

            #region Frequencies
            {
                int[] input = { 1, 2, 2, 3, 4, 4, 4 };
                PrintFrequencies(input);
            }
            #endregion





        }
        static void PrintFrequencies(int[] numbers)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            foreach (int num in uniqueNumbers)
            {
                int count = 0;

                foreach (int n in numbers)
                {
                    if (n == num)
                        count++;
                }

                string timesText = count == 1 ? "time" : "times";
                Console.WriteLine($"{num} → {count} {timesText}");
            }
        }

        private static void ShiftArrayLeft(int[] arr)
        {
            int firstElement = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = firstElement;

            foreach (var item in arr)
            {
                Console.Write($"{ item} ");
                
            }
        }

        private static string ReverseWordsInSentence(string sentence)
        {
            
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        private static bool Identical2Arrays(int[] A,int[] B)
        {
            
            bool areIdentical = true;
            if (A.Length != B.Length)
            {
                areIdentical = false;
            }
            else
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] != B[i])
                    {
                        areIdentical = false;
                        return false;

                        
                    }
                }
            }
            return areIdentical;
            
        }

        private static void factorialFunction(int n=1)
        {
           
            if (n < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {n} is: {factorial}");

        }

        private static void PrintSalaries(float[] S)
        {
           for (int i = 0; i < S?.Length; i++)
            {
                Console.WriteLine($"Salary of Employee {i + 1}: {S[i]}");
            }
        }

        private static void AddBouns(ref float[] S)
        {
           
            for (int i = 0; i < S?.Length; i++)
            {
                S[i] += S[i] * 0.1f; 
            }
            Console.WriteLine("Bonus added to each salary.");
        }

        private static void GetArrayFromUser(ref float[] S)
        {
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < S?.Length; i++)
            {
                float num;
                while (true)
                {
                    Console.Write("Please enter a positive Value: ");
                    string input = Console.ReadLine();
                    if (float.TryParse(input, out num) && num >= 0)
                        break;
                    Console.WriteLine("Invalid input. Please enter a positive Value.");
                }
                S[i] = num;
            }
           
            
        }

        static void IdentityMatrex(int n)
        { 
        for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
                /*
                 1 0 0
                 0 1 0
                 0 0 1
                 
                 */
            }
        }


    }
}
