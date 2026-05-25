using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mju23h_dtp_genrep_FAS4
{
    public class MyStrLib
    {
        /// <summary>
        /// Tests if a string is the same as itself reversed
        /// https://en.wikipedia.org/wiki/Palindrome
        /// </summary>
        /// <param name="S">the string to test if palindrome</param>
        /// <returns>true if palindrom</returns>
        /// <remarks>
        /// string is loweercased and whitespaces are removed 
        /// before testing whether S is a palindrom
        /// </remarks>
        public static bool IsPalindrom(string S)
        {
            string res = "";
            foreach (char c in S)
            {
                if (" \n\t\r".IndexOf(c) == -1)
                {
                    res += c;
                }
            }
            res = res.ToLower();
            return res == Reverse(res);
        }
        /// <summary>
        /// Reverses a string
        /// </summary>
        /// <param name="S">the string to reverse</param>
        /// <returns>a copy of the string S reversed</returns>
        public static string Reverse(string S)
        {
            char[] CS = S.ToCharArray();
            int half = CS.Length / 2;
            int last = CS.Length - 1;
            for (int i = 0; i < CS.Length / 2; i++)
            {
                char c = CS[i];
                CS[i] = CS[last - i];
                CS[last - i] = c;
            }
            return new string(CS);
        }
        /// <summary>
        /// Caesar encode a string using the 
        /// <a href="https://en.wikipedia.org/wiki/Caesar_cipher">Caesar cipher</a>.
        /// </summary>
        /// <param name="S">the string to encode</param>
        /// <param name="steps">number of steps to rotate letters</param>
        /// <returns>a copy of S Caesar encoded steps number of steps</returns>
        /// <remarks>
        /// The Caesar shift is performed on ASCII letter and numbers only,
        /// all other characters are kept unchanged
        /// </remarks>
        public static string Caesar(string S, int steps = 3)
        {
            char[] CS = S.ToCharArray();
            for (int i = 0; i < CS.Length; i++)
            {
                if ('a' <= CS[i] && CS[i] <= 'z')
                {
                    int lval = (int)(CS[i] - 'a');
                    lval = (lval - steps) % 26;
                    if (lval < 0) lval += 26;
                    CS[i] = (char)(lval + (int)'a');
                }
                if ('A' <= CS[i] && CS[i] <= 'Z')
                {
                    int lval = (int)(CS[i] - 'A');
                    lval = (lval - steps) % 26;
                    if (lval < 0) lval += 26;
                    CS[i] = (char)(lval + (int)'A');
                }
                if ('0' <= CS[i] && CS[i] <= '9')
                {
                    int lval = (int)(CS[i] - '0');
                    lval = (lval - steps) % 10;
                    if (lval < 0) lval += 10;
                    CS[i] = (char)(lval + (int)'0');
                }
            }
            return new string(CS);
        }
        /// <summary>
        /// Vigenère encode a string using a
        /// <a href=https://en.wikipedia.org/wiki/Vigen%C3%A8re_cipher">Vigenère cipher</a>
        /// </summary>
        /// <param name="S">the string to encode</param>
        /// <param name="password">the encoding key</param>
        /// <returns>a copy of S Vigenère encoded according to the key password</returns>
        /// <remarks>
        /// All whitespaces are removed and the string is lowercased before being
        /// Vigenère encode. The string S is correctly encoded if it is composed
        /// of ASCII letters only.
        /// </remarks>
        public static string Vigenere(string S, string password)
        {
            int[] passshift = new int[password.Length];
            password = password.ToLower();
            for (int i = 0; i < password.Length; i++)
            {
                passshift[i] = (int)password[i] - (int)'a';
            }

            string C = "";
            S = S.ToLower();
            for (int i = 0; i < S.Length; i++)
            {
                if ('a' <= S[i] && S[i] <= 'z')
                {
                    C += S[i];
                }
            }
            string res = "";
            for (int i = 0; i < C.Length; i++)
            {
                int lval = ((int)C[i] - (int)'a' + passshift[i]) % 26;
                res += (char)(lval + (int)'a');
            }
            return res;
        }
    }
}
