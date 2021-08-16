using System.Collections.Generic;

namespace Codility
{
    namespace Brackets
    {
        public class Brackets
        {
            public int Solution(string S)
            {
                Stack<char> stack = new Stack<char>();
                for (int i = 0; i < S.Length; i++)
                    switch (S[i])
                    {
                        case '[':
                        case '{':
                        case '(':
                            stack.Push(S[i]);
                            break;
                        case ']':
                            if (stack.Count == 0 || stack.Pop() != '[')
                                return 0;
                            break;
                        case '}':
                            if (stack.Count == 0 || stack.Pop() != '{')
                                return 0;
                            break;
                        case ')':
                            if (stack.Count == 0 || stack.Pop() != '(')
                                return 0;
                            break;
                    }
                return stack.Count > 0 ? 0 : 1;
            }
        }
    }
}
