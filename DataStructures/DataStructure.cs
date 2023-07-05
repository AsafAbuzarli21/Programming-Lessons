using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DataStructure
    {
        public class Node
        {
            public int Data;
            public Node Next = null;
        }

        public class LinkedList
        {
            public Node Head;

            public LinkedList()
            {
                Head = null;
            }

            public void ShowElements()
            {
                Node temp = Head;

                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }

            public void AddLast(int data)
            {
                Node newNode = new Node()
                {
                    Data = data,
                    Next = null,
                };

                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                Node temp = Head;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = newNode;
            }

            public void AddFirst(int data)
            {
                Node newNode = new Node()
                {
                    Data = data,
                    Next = null
                };

                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                Node temp = Head;

                newNode.Next = temp;
                Head = newNode;
            }

            public void AddPosition(int position, int data)
            {
                Node newNode = new Node()
                {
                    Data = data,
                    Next = null
                };

                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                Node temp = Head;

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
    }
}
