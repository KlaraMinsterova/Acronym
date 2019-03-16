using System;
using System.Collections.Generic;

namespace Acronym
{
    public static class Acronym
    {
        //here I can add any characters by which to split phrase into words
        private static readonly string[] CharactersToSplitBy = { " ", "-" };

        //here I can add any special cases of transforming word into letter
        private static readonly Dictionary<string, string> SpecialCases = new Dictionary<string, string>
        {
            { "the", "" }
        };

        public static string CreateAcronym(string phrase)
        {
            string acronym = "";
            string[] words = phrase.Split(CharactersToSplitBy, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (string word in words)
            {
                acronym += TransformWordIntoLetter(word);
            }

            return acronym;
        }

        private static string TransformWordIntoLetter(string word)
        {
            if (SpecialCases.TryGetValue(word.ToLower(), out string letter))
            {
                return letter;
            }
            //I can also possibly add other rules here
            else
            {
                return word[0].ToString().ToUpper();
            }
        }
    }
}
