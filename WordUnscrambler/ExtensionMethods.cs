using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    internal static class ExtensionMethods
    {
        public static bool isLanguageValid (this string language)
        {
            switch (language.ToUpper())
            {
                case "E":
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("");
                    return true;
                    break;
                case "F":
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-CA");
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }
    }
}
