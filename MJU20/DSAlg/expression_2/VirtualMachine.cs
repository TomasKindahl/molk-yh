using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using varnamespace;
using expression_2;

namespace virtualmachine
{
    public class VM
    {
        class OpStack
        {
            // A linked list containing integer operands
            public OpStack(int newVal, OpStack newNext)
            {
                // NYI!
            }
            public OpStack Push(int newVal)
            {
                // NYI!
                return new OpStack(0, null); // Stub code
            }
            public OpStack Pop()
            {
                // NYI!
                return null; // Stub code
            }
            public int Top()
            {
                // NYI!
                return 0; // Stub code
            }
        }
        public static int execVm(List<string> vmCode, VarNameSpace vars)
        {
            if (vmCode.Count == 0)
            {
                throw new NullReferenceException("Running empty virtual machine code!");
            }
            int PC = 0;
            OpStack st = new OpStack(-997, null);

            string opCode = vmCode[PC];

            while (opCode != "exit")
            {
                if (Scan.IsNum(opCode))
                {
                    st = st.Push(int.Parse(opCode));
                }
                else if (Scan.IsVar(opCode))
                {
                    st = st.Push(vars.Lookup(opCode));
                }
                else
                {
                    int op2 = st.Top();
                    st = st.Pop();
                    int op1 = st.Top();
                    st = st.Pop();
                    int res;
                    switch (opCode)
                    {
                        case "+": res = op1 + op2; break;
                        case "-": res = op1 - op2; break;
                        case "*": res = op1 * op2; break;
                        case "/": res = op1 / op2; break;
                        default: throw new NotImplementedException($"Unknown operator {opCode}");
                    }
                    st = st.Push(res);
                }
                PC++;
                opCode = vmCode[PC];
            }
            return st.Top();
        }

    }
}
