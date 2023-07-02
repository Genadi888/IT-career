using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _2._Динамична_реализация_на_списък
{
    public class DynamicList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return this.element; }
                set { this.element = value; }
            }

            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }

            public Node(object element, Node prevNode)
            {
                this.Element = element;
                prevNode.Next = this;
            }

            public Node(object element)
            {
                this.Element = element;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Argument cannot be null!");
            }

            if (this.head == null)
            {
                this.head = new Node(item);
            }
            else if (this.tail == null)
            {
                this.tail = new Node(item, this.head);
            }
            else
            {
                Node newNode = new Node(item, this.tail);
                this.tail = newNode;
            }

            this.Count++;
        }

        public object RemoveAt(int delIndex)
        {
            if (delIndex < 0 || delIndex >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = this.head;

            for (int curIndex = 0; curIndex <= delIndex; curIndex++)
            {
                if (curIndex == delIndex - 1)
                {
                    object deletedEl = current.Next.Element;
                    current.Next = current.Next.Next;
                    this.Count--;
                    return deletedEl;
                }
                else if (delIndex == 0)
                {
                    Node head = this.head;
                    this.head = this.head.Next;
                    this.Count--;
                    return head;
                }
                else if (delIndex == this.Count - 1 && curIndex == this.Count - 2)
                {
                    this.tail = current;
                    this.Count--;
                    return current.Next.Element;
                }

                current = current.Next;

                if (current == null)
                {
                    throw new IndexOutOfRangeException();
                }
            }

            throw new IndexOutOfRangeException("Invalid index");
        }

        public object Remove(object item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Argument cannot be null!");
            }

            Node current = this.head;

            while (current != null)
            {
                if (current.Next.Element.Equals(item))
                {
                    if (current.Next == this.tail)
                    {
                        this.tail = current;
                    }

                    current.Next = current.Next.Next;

                    this.Count--;
                    return item;
                }
                else if (current.Element.Equals(item) && current == this.head)
                {
                    this.head = this.head.Next;
                    this.Count--;
                    return item;
                }

                current = current.Next;
            }

            return -1;
        }

        public int IndexOf(object item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Argument cannot be null!");
            }

            Node current = this.head;
            int index = 0;

            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1;
        }

        public bool Contains(object item)
        {
            return this.IndexOf(item) != -1;
        }

        public object this[int index]
        {
            get 
            {
                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                if (index == -0)
                {
                    index = 0; // I set this to one to avoid going out of the array's boundaries
                }

                Node current = this.head;

                if (index < 0)
                {
                    if (Math.Abs(index) > this.Count)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    for (int j = 0; j <= this.Count - Math.Abs(index); j++)
                    {
                        if (j == this.Count - Math.Abs(index))
                        {
                            return current.Element;
                        }
                        current = current.Next;
                    }
                }
                else
                {
                    for (int j = 0; j <= index; j++)
                    {
                        if (j == index)
                        {
                            return current.Element;
                        }
                        current = current.Next;
                    }
                }

                throw new InvalidOperationException("Invalid index");
            }

            set
            {
                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value == null)
                {
                    throw new ArgumentNullException("Cannot set a null value!");
                }

                if (index == -0)
                {
                    index = 0;
                }

                Node current = this.head;

                if (index < 0)
                {
                    if (Math.Abs(index) > this.Count)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    for (int j = 0; j <= this.Count - Math.Abs(index); j++)
                    {
                        if (j == this.Count - Math.Abs(index))
                        {
                            current.Element = value;
                        }
                        current = current.Next;
                    }
                }
                else
                {
                    for (int j = 0; j <= index; j++)
                    {
                        if (j == index)
                        {
                            current.Element = value;
                        }
                        current = current.Next;
                    }
                }
            }
        }

        public override string ToString()
        {
            string res = "";

            for (int i = 0; i < this.Count; i++)
            {
                res += this[i] + ", ";
            }

            return res.Remove(res.Length - 2);
        }
    }
}
