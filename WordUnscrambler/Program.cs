using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();

        static void Main(string[] args)
        {
            bool terminateProgram = false;
            do
            {
                bool languageRequest = false;

                do 
                {
                    try
                    {
                        Console.WriteLine(Properties.strings.LanguageIntro);

                        String option = Console.ReadLine() ?? throw new Exception(Properties.strings.EmptyString);

                        // extension method takes the input and tests its result to see through a switch if its either E (for english) or F (for french)
                        languageRequest = option.isLanguageValid(); 

                        if(!languageRequest)
                        {
                            Console.WriteLine(Properties.strings.WrongFormat);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(Properties.strings.CatchError + ex.Message);

                    }

                } while(!languageRequest);


                bool succesful = false;

                do
                {
                    try
                    {
                        Console.WriteLine(Properties.strings.FormatRequest);

                        String option = Console.ReadLine() ?? throw new Exception(Properties.strings.EmptyString);

                        switch (option.ToUpper())
                        {
                            case "F":
                                Console.WriteLine(Properties.strings.PathRequest);
                                ExecuteScrambledWordsInFileScenario();
                                succesful = true;
                                break;
                            case "M":
                                Console.WriteLine(Properties.strings.ManualRequest);
                                ExecuteScrambledWordsManualEntryScenario();
                                succesful = true;
                                break;
                            default:
                                Console.WriteLine(Properties.strings.WrongFormat);
                                break;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(Properties.strings.CatchError + ex.Message);

                    }
                } while (!succesful);

                bool repeatRequest = true;

                do
                {
                    try
                    {

                        Console.WriteLine(Properties.strings.RepeatRequest);

                        String input = Console.ReadLine() ?? throw new Exception(Properties.strings.EmptyString);

                        switch (input.ToUpper())
                        {
                            case "Y":
                                repeatRequest = false;
                                terminateProgram = false;
                                break;

                            case "N":
                                Console.WriteLine(Properties.strings.FinishedProgram);
                                repeatRequest = false;
                                terminateProgram = true;
                                break;

                            default:
                                repeatRequest = true;
                                break;
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(Properties.strings.CatchError + ex.Message);
                        repeatRequest = false;
                        terminateProgram = true;
                    }

                }while (repeatRequest);
            } while (!terminateProgram);
        }

        private static void ExecuteScrambledWordsInFileScenario()
        {
            //read the name of the file
            var filename = Console.ReadLine();
            //use the read function to extract the words and put them in the array
            string[] scrambledWords = _fileReader.Read(filename);
            //send the list to the display function
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            //read the words and put them in a string
            string text = Console.ReadLine();
            //put the words in a list
            string[] scrambledWords = text.Split(new string[] { "," }, StringSplitOptions.None);

            //send the list to the display method
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            //read the list of words from the system file. 
            string[] wordList = _fileReader.Read("test.txt");

            //call a word matcher method to get a list of structs of matched words.
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            //print all the words that match
            Console.WriteLine(Properties.strings.DisplayMatchedWords);
            foreach (MatchedWord matchedWord in matchedWords)
            {
                Console.WriteLine(matchedWord);
            }
            
        }
    }
}
