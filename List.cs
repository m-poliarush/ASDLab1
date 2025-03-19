using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class CustomList<T>
    {
        private ListNode<T> head;
        public int count {  get; private set; }
        internal class ListNode<T>
        {
            public T data;
            public ListNode<T> next;
            
            public ListNode(T data, ListNode<T> next ) {
                this.data = data;
                this.next = next;
            }
            
        } 
        public CustomList()
        {
            this.head = null;
            this.count = 0;
        }
        public bool isEmpty()
        {
            if (count == 0) return true;
            else return false;
        }
        public bool AddAt(int index, T data)
        {
            if(index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(index > count)
            {
                index = count;
            }
            
            ListNode<T> currentNode = this.head;

            if (this.isEmpty() || index == 0)
            {
                this.head = new ListNode<T>(data, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = new ListNode<T>(data, currentNode.next);
            }
            count++;
            return true;
        }
        public bool AddLast(T data)
        {
            return AddAt(count, data);
        }
        public bool AddFirst(T data)
        {
            return AddAt(0, data);
        }
        public T RemoveAt(int index)
        {
            if(index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }
           
            ListNode<T> currentNode = this.head;
            T result;
            if (index == 0)
            {
                result = currentNode.data;
                this.head = currentNode.next;
                
            }
            else
            {
                for(int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.next;
                }
                 result = currentNode.next.data;
                currentNode.next = currentNode.next.next;
            }
            count--;
            return result;

        }
        public void Clear()
        {
            this.head = null;
            this.count = 0;
        }
        public T GetAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }

            
            ListNode<T> currentNode = this.head;
            if (index == 0) return currentNode.data;
            else
            {
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.next;
                }
                return currentNode.data;
            }
        }
        

    }
}
