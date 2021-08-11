using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsValidation
{
    class Validation
    {
        public bool BracketsValidation(string input1)
        {
            Stack<char> stack = new Stack<char>();
            int iCnt =0;

            if (input1 == null || input1.Length == 0)
            {
                return true;
            }


            for (int i = 0; i <= input1.Length - 1; i++)
            {
                if (input1[i] == '{')
                {
                    stack.Push(input1[i]);
                }
                else if (input1[i] == '}')
                {
                    if(stack.Count != 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        iCnt++;
                    }
                }
            }

            if (stack.Count == 0 && iCnt == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
