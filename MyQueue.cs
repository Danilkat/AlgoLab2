using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLab2
{
    internal class ListNode<T>
    {
        public T Data { get; }
        public ListNode<T> Next { get; set; }

        public ListNode(T data)
        {
            Data = data;
            Next = null;
        }
    }
    internal class MyQueue<T>
    {
        private ListNode<T> front;
        private ListNode<T> rear;
        public int Size { get; private set; }

        public MyQueue()
        {
            front = null;
            rear = null;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public void Enqueue(T item)
        {
            ListNode<T> newNode = new ListNode<T>(item);

            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            Size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T data = front.Data;
            front = front.Next;

            if (front == null)
            {
                rear = null;
            }
            Size--;

            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return front.Data;
        }

        public void PrintQueue()
        {
            var current = front;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
