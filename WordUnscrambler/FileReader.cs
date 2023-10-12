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
            StreamReader reader = new StreamReader(filename);

            string text = reader.ReadToEnd();

            string[] words = text.Split(new string[] { "," }, StringSplitOptions.None);

            return words;
        }
    } 
}

