using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkRen
{
    class Lib
    {
        // Zero based... Adapt to 
        public string Left(string s, int pos)
        {
            //pos--;
            return s.Substring(0, pos);
        }

        public string Right(string s, int pos)
        {
            //pos--;
            return s.Substring(s.Length - pos, pos);
        }

        public string Mid(string s, int pos, int len)
        {
            //pos--;
            return s.Substring(pos, len);
        }

        /// <summary>
        /// Replace in string s with ins.
        /// </summary>
        /// <param name="ins"></param>
        /// <param name="s"></param>
        /// <param name="pos"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        //  ll = L.MidReplace("?",ll, Ss + i, 1);
        public string MidReplace(string ins, string s, int pos, int len)
        {
            string l = Left(s, pos);
            string r = Right(s, s.Length-pos);
            s = l + ins + r;

            return s;
        }
    }
}
