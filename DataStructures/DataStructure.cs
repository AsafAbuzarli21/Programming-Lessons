using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DataStructure
    {
        public class Node3
        {
            public int Data;
            public Node3 Next = null;
        }

        public class Node
        {
            public int Data;
            public Node Next;
            public Node Previous;

            public Node()
            {

            }

            public Node(int data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }
        }

        public class LinkedList
        {
            public Node3 Head;

            public LinkedList()
            {
                Head = null;
            }

            public void ShowElements()
            {
                Node3 temp = Head;

                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }

            public void AddLast(int data)
            {
                Node3 newNode = new Node3()
                {
                    Data = data,
                    Next = null,
                };

                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                Node3 temp = Head;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = newNode;
            }

            public void AddFirst(int data)
            {
                Node3 newNode = new Node3()
                {
                    Data = data,
                    Next = null
                };

                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                Node3 temp = Head;

                newNode.Next = temp;
                Head = newNode;
            }

            public void AddPosition(int position, int data)
            {
                Node3 newNode = new Node3()
                {
                    Data = data,
                    Next = null
                };

                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                Node3 temp = Head;

                //Asaf, Kanan, Sahib, Faiq, Ayxan, Next=null

                //position = 3 , data = nemet

                for (int i = 1; i < position - 1; i++)
                {
                    if (temp.Next != null)
                        temp = temp.Next;
                }

                newNode.Next = temp.Next;
                temp.Next = newNode;

            }



        }

        public class CircleLinkedList
        {
            public Node Head;
            public Node Tail;
            private int _size;

            public CircleLinkedList()
            {
                Head = null;
                Tail = null;
                _size = 0;
            }

            public int GetSize()
            {
                return _size;
            }

            public bool IsEmpty()
            {
                return _size == 0;
            }

            public void Show()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("List is empty!");
                    return;
                }

                Node temp = Head;

                for (int i = 1; i <= _size; i++)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }

            public void AddLast(int data)
            {
                Node newNode = new Node(data);

                if (IsEmpty())
                {
                    Head = newNode;
                    Tail = newNode;
                    Head.Next = newNode;
                    _size++;
                    return;
                }

                Tail.Next = newNode;
                newNode.Next = Head;
                Tail = newNode;
                _size++;
            }

            public void AddFirst(int data)
            {
                Node newNode = new Node(data);

                if (IsEmpty())
                {
                    Head = newNode;
                    Tail = newNode;
                    Head.Next = newNode;
                    _size++;
                    return;
                }

                newNode.Next = Head;
                Head = newNode;
                Tail.Next = newNode;
                _size++;
            }

            // AddPosition
        }

    }
}
