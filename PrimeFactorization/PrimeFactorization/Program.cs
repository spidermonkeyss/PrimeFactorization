//Prime Factorization – Have the user enter a number and find all Prime Factors (if there are any) and display them.
using System;
using System.Collections.Generic;
using Utlity;

namespace PrimeFactorization
{
    class Program
    {
        static List<int> primeNumbers = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check for prime factors");
            int input = UserInput.GetUserNumericInput();
            CheckIfPrimeNumber(input);
            string output = "Prime factors: ";
            foreach (int num in primeNumbers)
            {
                output += num + ", ";
            }
            output = output.Substring(0, output.Length - 2);
            Console.WriteLine(output);
        }

        static bool CheckIfPrimeNumber(int baseNumber)
        {
            List<int> wholeNumbers = new List<int>();

            float halfValue = (float)baseNumber / 2.0f;
            for (int i = 2; i < halfValue; i++)
            {
                int remainder = baseNumber % i;
                float num = (float)baseNumber / (float)i;
                //Console.Write(baseNumber + " / " + i);
                if (remainder == 0)
                {
                    //Console.WriteLine("     " + num + ":whole");
                    wholeNumbers.Add(i);
                    wholeNumbers.Add((int)num);
                    if (CheckIfPrimeNumber(i))
                        primeNumbers.Add(i);
                    if (CheckIfPrimeNumber((int)num))
                        primeNumbers.Add((int)num);
                    break;
                }
                else
                {
                    //Console.WriteLine("     " + num +":not");
                }
            }

            if (wholeNumbers.Count == 0)
                return true;

            return false;
        }
    }
}
