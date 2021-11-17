using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingExerciseSample
{
    public class StringFormatter
    {
        private static readonly string SEPERATOR = " ";
        public static string GetExpectedResult(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                throw new ArgumentException("The input is not valid", nameof(sentence));

            // Regex Pattern to check if the input contains only alphabets and spaces
            var pattern = new Regex("^[a-zA-Z\\s]*$");

            var isMatchingPattern = pattern.IsMatch(sentence);
            if (!isMatchingPattern)
            {
                throw new ArgumentException("Input has special characters", nameof(sentence));
            }
            var modifiedResponse = new List<string>();
            var listOfWords = sentence.Split(" ").ToList();

            foreach (var word in listOfWords)
            {
                int countOfDistinctLettersInBetween;
                if (word.Length <= 2)
                {
                    modifiedResponse.Add(word);
                    continue;
                }
                countOfDistinctLettersInBetween = word.ToLower().Skip(1).SkipLast(1).Distinct().Count();
                var firstLetter = word.First().ToString();
                var lastLetter = word[word.Length - 1].ToString();
                var modifiedWord = new StringBuilder();
                modifiedWord.Append(firstLetter + countOfDistinctLettersInBetween + lastLetter);
                modifiedResponse.Add(modifiedWord.ToString());
            }

            return string.Join(SEPERATOR, modifiedResponse);
        }   
    }
}
