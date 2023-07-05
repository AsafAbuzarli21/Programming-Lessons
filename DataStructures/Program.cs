using static DataStructures.DataStructure;

namespace DataStructures
{
    internal class Program
    {
        public class Node2
        {
            public int Data;
            public Node2 Next;

        }

        public class LinkedList2
        {
            public Node2 Head;

            public LinkedList2()
            {
                Head = null;
            }

            public void Show()
            {
                if (Head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }

                Node2 temp = Head;

                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }

            public void AddLast(int data)
            {
                Node2 newNode = new Node2()
                {
                    Data = data,
                    Next = null
                };

                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                Node2 temp = Head;

                while (temp.Next != null)
                    temp = temp.Next;

                temp.Next = newNode;


            }

            public void AddFirst(int data)
            {
                Node2 newNode = new Node2()
                {
                    Data = data,
                    Next = null
                };

                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                newNode.Next = Head;
                Head = newNode;
            }

            public void AddCustomPosition(int position, int data)
            {
                Node2 newNode = new Node2()
                {
                    Data = data,
                    Next = null
                };

                if (position == 1)
                {
                    newNode.Next = Head;
                    Head = newNode;
                    return;
                }

                Node2 temp = Head;

                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.Next;
                    }
                }

                newNode.Next = temp.Next;
                temp.Next = newNode;
            }

            public void RemoveFirst()
            {
                if (Head == null)
                {
                    Console.WriteLine("List is Empty");
                    return;
                }

                Head = Head.Next;
            }

            public void RemoveLast()
            {
                if (Head == null)
                {
                    Console.WriteLine("List is Empty");
                    return;
                }

                if (Head.Next == null)
                {
                    Head = null;
                    return;
                }

                Node2 temp = Head;

                while (temp.Next.Next != null)
                    temp = temp.Next;

                temp.Next = null;
            }

            public void RemoveCustomPosition(int position)
            {
                //empty list
                if (Head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }

                //one element list
                if (position == 1 && Head.Next == null)
                {
                    Head = null;
                }

                Node2 temp = Head;

                for (int i = 1; i < position; i++)
                {
                    if (temp != null)
                        temp = temp.Next;
                }

                temp.Next = temp.Next.Next;
            }
        }

        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            linkedList.AddFirst(777);
            linkedList.AddFirst(99);

            linkedList.AddPosition(3, 111);

            linkedList.AddPosition(10, 888);

            linkedList.AddPosition(11000, 1111111);

            linkedList.ShowElements();
        }
    }
}