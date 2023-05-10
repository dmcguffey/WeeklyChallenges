using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //find the evens and add them, then find the odds and subtract them.
            int result = numbers.Where(x => x % 2 == 0).Sum(x => x) - numbers.Where(x => x % 2 == 1).Sum(x => x);
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
           //make a list and add strings to list
           List <string> strList = new List <string>
            { str1, str2, str3, str4 };
            //Find the smallest string in length
            return strList.Select(x => x.Length).Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //New array of numbers given
            List <int> numberList = new List <int> { number1, number2, number3, number4 };
            return numberList.Select(x => x).Min();

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            

            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;

            }
            else
            {
                return true;
            }                

        }

        public bool IsStringANumber(string input)
        {
            int result;
            decimal alt;
            if(int.TryParse(input, out result) || decimal.TryParse(input, out alt))
            {
                return true;
            }

            return false;

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs.Count(objs => objs == null) > objs.Count(objs => objs != null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            
            if (numbers == null || numbers.Length == 0 || numbers.All(x => x % 2 == 1))
            {
                return 0;
            }

            double average = numbers.Where(x => x % 2 == 0).Average();
            return average;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "Input must be non-negative.");
            }
            else if (number <= 1)
            {
                return 1;
            }
            else
            {
                int result = 1;
                for (int i = number; i > 1; i--)
                {
                     result *= i;
                }
                    return result;
            }

        }
    }
}
