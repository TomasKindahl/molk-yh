using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuntingyard
{
    class ShuntingYard
    {
        enum TokTyp { IDF, EQ, NUM, LPAR, RPAR, OP, NONE, ERROR }
        class Token
        {
            public TokTyp type = TokTyp.NONE;
            public string val;
            public Token(TokTyp type, string val)
            {
                this.type = type; this.val = val;
            }
            public override string ToString()
            {
                return $"[{type}]{val}";
            }
        }
        static int precedence(string op)
        {
            if (op == "+" || op == "-") return 1;
            else if (op == "*" || op == "/") return 2;
            else return -1;
        }
        static bool GetNextTokTyp(out Token tok, ref string rest)
        {
            char[] Ops = { '+', '-', '*', '/' };

            tok = new Token(TokTyp.NONE, "");
            while (rest.Length > 0 && rest[0] == ' ') rest = rest.Substring(1);
            if (rest.Length == 0)
            {
                return false;
            }
            if (Char.IsLetter(rest[0]))
            {
                do
                {
                    tok.val += rest[0];
                    rest = rest.Substring(1);
                } while (rest.Length > 0 && (Char.IsLetter(rest[0]) || Char.IsDigit(rest[0])));
                tok.type = TokTyp.IDF;
            }
            else if (Char.IsDigit(rest[0]))
            {
                do
                {
                    tok.val += rest[0];
                    rest = rest.Substring(1);
                } while (rest.Length > 0 && (Char.IsDigit(rest[0]) || rest[0] == '.'));
                tok.type = TokTyp.NUM;
            }
            else if (rest[0] == '=')
            {
                tok.val += rest[0];
                rest = rest.Substring(1);
                tok.type = TokTyp.EQ;
            }
            else if (rest[0] == '(')
            {
                tok.val += rest[0];
                rest = rest.Substring(1);
                tok.type = TokTyp.LPAR;
            }
            else if (rest[0] == ')')
            {
                tok.val += rest[0];
                rest = rest.Substring(1);
                tok.type = TokTyp.RPAR;
            }
            else if (Ops.Contains(rest[0]))
            {
                tok.val += rest[0];
                rest = rest.Substring(1);
                tok.type = TokTyp.OP;
            }
            else
            {
                tok.type = TokTyp.ERROR;
                return false;
            }
            return true;
        }
        public static double Execute(string expression)
        {
            List<Token> otq = new List<Token>();
            Stack<Token> ops = new Stack<Token>();
            Token tok, top;
            while (GetNextTokTyp(out tok, ref expression))
            {
                // Console.Write($"[{tok.type}]{tok.val} ");
                // Shunting yard here:
                switch (tok.type)
                {
                    case TokTyp.NUM:
                        otq.Add(tok);
                        break;
                    case TokTyp.OP:
                        if (ops.Count > 0)
                        {
                            top = ops.Peek();
                            while (ops.Count > 0 &&
                                  (top.type == TokTyp.OP &&
                                   precedence(top.val) >= precedence(tok.val)))
                            {
                                otq.Add(ops.Pop());
                                if (ops.Count == 0) break;
                                top = ops.Peek();
                            }
                        }
                        ops.Push(tok);
                        break;
                    case TokTyp.LPAR:
                        ops.Push(tok);
                        break;
                    case TokTyp.RPAR:
                        top = ops.Peek();
                        while (ops.Count > 0 && top.type != TokTyp.LPAR)
                        {
                            otq.Add(ops.Pop());
                            top = ops.Peek();
                        }
                        // Here assert that ops has a LPAR at the top, and drop that
                        break;
                }
            }
            while (ops.Count > 0)
                if (ops.Peek().type != TokTyp.LPAR)
                    otq.Add(ops.Pop());
                else
                    ops.Pop();
            // Console.WriteLine();

            Stack<double> cst = new Stack<double>();
            foreach (Token t in otq)
            {
                // Console.WriteLine(t);
                if (t.type == TokTyp.NUM)
                    cst.Push(double.Parse(t.val));
                else if (t.type == TokTyp.OP)
                {
                    double x, y, res;
                    y = cst.Pop(); x = cst.Pop();
                    switch (t.val)
                    {
                        case "+":
                            cst.Push(x + y);
                            break;
                        case "-":
                            cst.Push(x - y);
                            break;
                        case "*":
                            cst.Push(x * y);
                            break;
                        case "/":
                            cst.Push(x / y);
                            break;
                    }
                }
            }
            return cst.Pop();
        }
    }
}