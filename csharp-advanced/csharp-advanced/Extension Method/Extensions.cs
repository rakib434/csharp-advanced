using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_advanced.Extension_Method
{
    public static class Extensions
    {
        public static string Shorten (this String str,int numeberOfWords){
            if (numeberOfWords < 0)
                throw new ArgumentOutOfRangeException("number of words should be greater than or equal to 0.");

            if (numeberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numeberOfWords)
                return str;

            return String.Join(" ", words.Take(numeberOfWords)) + "...";
        }
    }
}
