using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class CustomStack<T>
    {
        private int top = 0;
        private int size;
        public int count { get; private set; }

        private T[] stack;

        public CustomStack(int size)
        {
            this.size = size;
            stack = new T[size];
            count = 0;
        }

        public bool IsEmpty()
        {
            if (top == 0) return true;

            else return false;

        }
        public bool isFull()
        {
            if (top > size) return true;
            else return false;
        }

        public void Push(T data)
        {
            if (isFull())
            {
                throw new Exception("Stack Overflow");
            }
            stack[top] = data;
            top++;
            count++;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack Underflow");
            }
            else
            {
                top--;
                count--;
                return stack[top];
            }
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack Underflow");
            }
            return stack[--top];
        }
    }
    }
