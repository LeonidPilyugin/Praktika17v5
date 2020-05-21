using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_17
{
    static class Translate
    {
        public static string translate10(string s)
        {
            int n = 0;
            for (int i = 0; i < s.Length; i++)
                n += (s[i] - 48) * (int)Math.Pow(2, s.Length - i - 1);
            return n.ToString();
        }
        public static string translate8(string s)
        {
            string answer = "";
            string temp = "";
            for(int i = s.Length - 1; i > -1;)
            {
                if (i > -1) temp += s[i--];
                if (i > -1) temp += s[i--];
                if (i > -1) temp += s[i--];
                answer += translate10(reverse(temp));
                temp = "";
            }
            return reverse(answer);
        }
        public static string translate16(string s)
        {
            int n = 0;
            for (int i = 0; i < s.Length; i++)
                n += (s[i] - 48) * (int)Math.Pow(2, s.Length - i - 1);
            return n.ToString("X");
        }
        private static string reverse(string s)
        {
            string answer = "";
            for (int i = s.Length - 1; i > -1; i--)
                answer += s[i];
            return answer;
        }
    }
}
