using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }
            //increment from the start number until you find the number divisible by n
            startNumber++;

            while(startNumber % n != 0)
            {
                startNumber++;
            }

            return startNumber;


       }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //return false if the number is null **DETERMINE IF NULL BEFORE ANY OTHER CODE IS WRITTEN**
            if (numbers == null)
            {
                return false;
            }

            if (numbers.Length== 0)
            {
                return false;
            }

            var check = numbers[0];


            foreach (var number in numbers)
            {
                //if number is greater than check
                if ( number >= check)
                {
                    check = number;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var add = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0 || numbers[i] == 0)
                {
                    add = add + numbers[i + 1];
                }
            }
            return add;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length == 0)
            {
                return "";
            }
            else
            {
                string sentence = string.Join(" ", words.Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x)));


                if(!string.IsNullOrWhiteSpace(sentence))
                {
                    sentence += ".";
                }

                return sentence;
            }

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var fourthElements = new List<double>();

            if(elements == null || elements.Count == 0)
            {
                return fourthElements.ToArray();
            }

            foreach(var element in elements)
            {
                if(element % 4 == 0)
                {
                    fourthElements.Add(element);
                }
            }

            return fourthElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            //automatically return false for null or if length is 0
            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            //see if two different numbers in the array can add to the target number
            for(int i = 0; i < nums.Length; i++)
            {
                var add = nums[i]; //We are going to use this to add in the sum variable at the bottom. rotate each integer
                for (int j = i + 1; j < nums.Length; j++) //the nested loop will make sure the integer added first is not the same as the one in the second
                {
                    var sum = nums[i] + nums[j]; //add
                    if (sum == targetNumber) // return true if the sum = target Number
                    {
                        return true;
                    }
                }
            }

            return false;

        }
    }
}
