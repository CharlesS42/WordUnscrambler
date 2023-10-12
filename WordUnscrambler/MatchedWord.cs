using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    struct MatchedWord
    {
        public MatchedWord(string scrambledWord, string word)
        {
            ScrambledWord = scrambledWord;
            Word = word;
        }

        public string ScrambledWord { get; set; }
        public string Word { get; set; }

        //override the toString to print the word and the scrambled word that match and adding an equal sign
        public override string ToString()
        {
            return Word.ToString() + " = " + ScrambledWord.ToString();
        }
    }
}
