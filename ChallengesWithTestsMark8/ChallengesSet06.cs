using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //words or any of its string can be null
            if(words == null || words.Contains(null))
            {
                return false;
            }

            //decide if we want to ignore the case of a word or not
            if (ignoreCase == true)
            {
                //lower all cases in the words
                foreach (var check in words)
                {
                    if(check.ToLower() == word)
                    {
                        return true;
                    }
                }
            }
            else
            {
                //all words are case sensitive
                foreach (var check in words)
                {
                    if (check == word)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            //prime number cannot be a number less than or equal to one
            if(num <= 1)
            {
                return false;
            }
            //I still have a hard time on how to come up with this conclusion to be honest. Mainly the complexity of using square root in this problem
            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //return -1 for a null or empty string
            if(string.IsNullOrEmpty(str))
            {
                return -1;
            }
            //create a dictionary where the char corresponds with an int
            var count = new Dictionary<char, int>();
            //this loop counts the number of char repeated, it at all
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (count.ContainsKey(str[i]))
                {
                    count[c]++;
                }
                else
                {
                    count[c] = 1;
                }

            }
            //second loop examines the char count and returns the one that equals 1 as the currect index
            for (int i = str.Length -1; i >= 0; i--)
            {
                char c = str[i];
                if (count[c] ==1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0) //Always build a failsafe for null or empty array
            {
                return 0;
            }

            var number = 0;
            var numberCompare = 1;
            //count every number that appears in this list
            for (int i = 1; i < numbers.Length; i++) //start the loop on the second index, then compare with the previous index
            {
                if (numbers[i] == numbers[i-1]) //comparison equal to each other
                {
                    numberCompare++; // add to the compare number
                }
                else
                {
                    number = Math.Max(number, numberCompare); //once there is a break in consecutive numbers, add the new occurrence to number
                    numberCompare = 1; //reset compare number so were not adding to it continuously.
                }
            }

            number = Math.Max(number, numberCompare);
            //return number that had the greatest number of occurrences
            return number;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            {
                //return an empty array if the list is empty or has null
                if (n < 1 || elements == null || elements.Count == 0)
                {
                    return new double[0];
                }
                //declare new list to store new variables
                List<double> result = new List<double>();
                //i starts out as one less than n, i stops at the last element, and i increments by n
                for (int i = n - 1; i < elements.Count; i += n)
                {
                    //for every nth value, add it to your new list. ex n = 2; list{1,2,3} add by two, then add 2 to new list
                    result.Add(elements[i]);
                }
                //must be converted to array for method
                return result.ToArray();
            }
        }
    }
}
