using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    class CheckBrackets
    {
        //"([()])" valid
        //"(([)])" invalid
        //"(((])[))" invalid
        //"((([])[]))" valid
        //"[((([])[]))]" valid
        public static bool CheckBracketsValid(string str)
        {
            if (String.IsNullOrEmpty(str)) return true;
            Stack<char> stack = new Stack<char>();
            try
            {
                foreach (char c in str.ToCharArray())
                {
                    switch (c)
                    {
                        case '(':
                        case '[':
                            stack.Push(c);
                            break;
                        case ')':
                            if (stack != null && stack.Pop() != '(') return false;
                            break;
                        case ']':
                            if (stack.Pop() != '[') return false;
                            break;
                    }

                }
            }
            catch (Exception)
            {
                return false;
            }

            if (stack.Count != 0) return false;
            return true;
        }
    }
}
