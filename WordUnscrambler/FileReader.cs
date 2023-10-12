using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            //create an instance of the streamreader to be able to read the file
            StreamReader reader = new StreamReader(filename);

            //use the text reader to read our file 
            string text = reader.ReadToEnd();

            //take the text and separate the words after each comma and put them in the array
            string[] words = text.Split(new string[] { "," }, StringSplitOptions.None);

            //return the list
            return words;
        }
    } 
}

