using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //bool containsWord = false;

            //if (string.Equals(words, null-0) || words.Contains(null))
            //{
            //    return false;
            //}

            //if (ignoreCase == true)
            //{
            //    word = word.ToLower();

            //    List<string> lc = words.Select(x => x.ToLower()).ToList();

            //    containsWord = lc.Contains(word);
            //}

            //if (ignoreCase == false)
            //{
            //    containsWord = words.Contains(word);
            //}

            //return containsWord;

            return (ignoreCase) ? words?.Select(x => x?.ToLower()).Contains(word) ?? false : words?.Contains(word) ?? false;


        }

        public bool IsPrimeNumber(int num)
        {
            int a = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {

            int index = -1;
            bool uIndex;

            for (var i = 0; i < str.Length; i++)
            {
                uIndex = true;

                for (var j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uIndex = false;
                    }
                }
                if (uIndex == true)
                {
                    index = i;
                }
            }
            return index;

            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int a = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }
                if (currentCount > a)
                {
                    a = currentCount;
                }
            }
            return a;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {

            List<double> nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }

            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }

            return nthElement.ToArray();

        }
    }
}