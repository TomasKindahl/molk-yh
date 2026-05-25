using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expression_1
{
    public class Scan
    {
        enum Charmode
        {
            var, num, op, none
        }
        static bool isAlpha(char c)
        {
            return 'a' <= c && c <= 'z';
        }
        static bool isNum(char c)
        {
            return '0' <= c && c <= '9';
        }
        static bool isOp(char c)
        {
            return c == '+' || c == '-' || c == '*'
                || c == '/' || c == '^'
                || c == '=' || c == '<' || c == '>';
        }
        public static string[] Tokenize(string cmd)
        {
            List<string> res = new List<string>(0);
            string str = "";
            Charmode entry = Charmode.none;
            for (int i = 0; i < cmd.Length; i++)
            {
                switch (entry)
                {
                    case Charmode.none:
                        if (isAlpha(cmd[i]))
                        {
                            str = $"{cmd[i]}";
                            entry = Charmode.var;
                        }
                        else if (isNum(cmd[i]))
                        {
                            str = $"{cmd[i]}";
                            entry = Charmode.num;
                        }
                        else if (isOp(cmd[i]))
                        {
                            str = $"{cmd[i]}";
                            entry = Charmode.op;
                        }
                        break;
                    case Charmode.var:
                        if (isAlpha(cmd[i]))
                        {
                            str = $"{str}{cmd[i]}";
                        }
                        else if (isNum(cmd[i]))
                        {
                            res.Add(str);
                            str = $"{cmd[i]}";
                            entry = Charmode.num;
                        }
                        else if (isOp(cmd[i]))
                        {
                            res.Add(str);
                            str = $"{cmd[i]}";
                            entry = Charmode.op;
                        }
                        break;
                    case Charmode.num:
                        if (isAlpha(cmd[i]))
                        {
                            res.Add(str);
                            str = $"{cmd[i]}";
                            entry = Charmode.var;
                        }
                        else if (isNum(cmd[i]))
                        {
                            str = $"{str}{cmd[i]}";
                        }
                        else if (isOp(cmd[i]))
                        {
                            res.Add(str);
                            str = $"{cmd[i]}";
                            entry = Charmode.op;
                        }
                        break;
                    case Charmode.op:
                        if (isAlpha(cmd[i]))
                        {
                            res.Add(str);
                            str = $"{cmd[i]}";
                            entry = Charmode.var;
                        }
                        else if (isNum(cmd[i]))
                        {
                            res.Add(str);
                            str = $"{cmd[i]}";
                            entry = Charmode.num;
                        }
                        else if (isOp(cmd[i]))
                        {
                            str = $"{str}{cmd[i]}";
                        }
                        break;
                }
            }
            res.Add(str);
            return res.ToArray();
        }
        public static bool IsVar(string str)
        {
            return isAlpha(str[0]);
        }
        public static bool IsNum(string str)
        {
            try
            {
                int val = Convert.ToInt32(str);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public static bool Is(string str, string val)
        {
            return str == val;
        }
    }
}
