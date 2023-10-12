using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();
            
            foreach(string w in scrambledWords) 
                // repeat the process of conversion accross every word of the scrambledWords array
            {
                char[] arrScramble = w.ToLower().Replace(" ", "").ToCharArray(); // CtA -> 'c', 't', 'a'
                Array.Sort(arrScramble); // 'c', 't', 'a' -> 'a', 'c', 't'
                string scramWord = new string(arrScramble);
                
                foreach (string x in wordList) // repeat the process of conversion accross every word of the wordList array
                {
                    char[] arrWList = x.ToLower().Replace(" ", "").ToCharArray();
                    Array.Sort(arrWList);
                    string wordOnList = new string(arrWList);

                    if(wordOnList == scramWord) // compare each of the words in wordList with the current scramWord to seek any match, return both when it does.
                    {
                        matchedWords.Add(new MatchedWord(w, x));
                    }
                }
            }

            return matchedWords;
        } 
    }

}
