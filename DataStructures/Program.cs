namespace DataStructures
{
    internal class Program
    {
        public class Node
        {
            public int Data;
            public Node Next;

        }

        public class LinkedList
        {
            public Node Head;

            public LinkedList()
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
                    Next = null
                };

                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                Node temp = Head;

                while (temp.Next != null)
                    temp = temp.Next;

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

                newNode.Next = Head;
                Head = newNode;
            }

            public void AddCustomPosition(int position, int data)
            {
                Node newNode = new Node()
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

                Node temp = Head;

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

                Node temp = Head;

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

                Node temp = Head;

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

            Node node1 = new Node();
            node1.Data = 1;
            node1.Next = null;

            linkedList.Head = node1;

            Node node2 = new Node();
            node2.Data = 2;
            node2.Next = null;

            node1.Next = node2;

            Node node3 = new Node();
            node3.Data = 3;
            node3.Next = null;

            node2.Next = node3;

            linkedList.AddFirst(21);

            linkedList.AddLast(22);

            linkedList.AddCustomPosition(3, 456);

            //linkedList.RemoveLast();

            //linkedList.RemoveFirst();

            linkedList.Show();

        }
    }
}