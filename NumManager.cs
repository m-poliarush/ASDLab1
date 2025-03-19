using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class NumManager
    {
        private static int toOct(int input)
        {
            int num = input;
            int remainder;
            string buffer = "";
            while (num > 0)
            {
                remainder = num % 8;
                num = num / 8;
                buffer += remainder.ToString();
            }
            var result = new string(buffer.ToCharArray().Reverse().ToArray());
            return Int32.Parse(result);
        }
        public static void MoveNumbers(ref CustomList<int> list, ref CustomStack<int> stack)
        {
            
            if(list.isEmpty()) throw new Exception("List mustn't be empty");
            if (stack.count > 0) throw new Exception("Stack must be empty");
            while (!list.isEmpty()) { 
                if(list.GetAt(0) > 0)
                {
                    stack.Push(toOct(list.RemoveAt(0)));
                }
                else
                {
                    list.RemoveAt(0);
                }
            }

        }
    }
}
