namespace DataStructures
{
    internal class Program
    {
        public class Node
        {
            public int Data;
            public Node Next;

            public Node()
            {

            }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public class LinkedList2
        {
            public Node Head;

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

            public void RemoveEvenNumbers()
            {
                if (Head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }

                Node temp = Head;

                while (temp.Next != null)
                {
                    if (temp.Next.Data % 2 == 0)
                    {
                        temp.Next = temp.Next.Next;
                        continue;
                    }

                    temp = temp.Next;
                }

                if (Head.Data % 2 == 0)
                    Head = Head.Next;

            }
        }

        public class Queue
        {
            public Node Head;
            public Node Tail;

            public Queue()
            {
                Head = null;
                Tail = null;
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

            public void Enqueue(int data)
            {
                var newNode = new Node(data);

                if (Head == null)
                {
                    Head = newNode;
                    Tail = newNode;
                    return;
                }

                Tail.Next = newNode;
                Tail = newNode;

            }

            public int Dequeue()
            {
                int peek;

                if (Head == null)
                {
                    return -1;
                }

                peek = Head.Data;
                Head = Head.Next;

                return peek;
            }

            public int Peek()
            {
                if (Head == null)
                {
                    return -1;
                }

                return Head.Data;
            }

            public bool IsEmpty()
            {
                if (Head == null)
                    return true;

                return false;
            }
        }

        public class Stack
        {
            public Node Top;

            public Stack()
            {
                Top = null;
            }

            public void Show()
            {
                if (Top == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }

                Node temp = Top;

                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }

            public void Push(int data)
            {
                var newNode = new Node(data);

                if (Top == null)
                {
                    Top = newNode;
                    return;
                }

                newNode.Next = Top;
                Top = newNode;
            }

            public int Pop()
            {
                int peek;

                if (Top == null)
                {
                    return -1;
                }

                peek = Top.Data;
                Top = Top.Next;

                return peek;
            }

            public int Peek()
            {
                if (Top == null)
                {
                    return -1;
                }

                return Top.Data;
            }

            public bool IsEmpty()
            {
                return Top == null;
            }
        }

        public class CircularLinkedList
        {
            public Node Head;
            public Node Tail;

            int _size = 0;

            public CircularLinkedList()
            {
                Head = null;
                Tail = null;
            }

            public int Length()
            {
                return _size;
            }

            public bool IsEmpty()
            {
                return _size == 0;
            }

            public void Show()
            {
                if (_size == 0)
                {
                    Console.WriteLine("There is no element in the list");
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
                    newNode.Next = newNode;
                    Head = Tail = newNode;
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
                    newNode.Next = newNode;
                    Head = Tail = newNode;
                    _size++;
                    return;
                }

                Tail.Next = newNode;
                newNode.Next = Head;
                Head = newNode;
                _size++;
            }

            public void AddPosition(int data, int position)
            {
                Node newNode = new Node(data);

                if (IsEmpty())
                {
                    newNode.Next = newNode;
                    Head = Tail = newNode;
                    _size++;
                    return;
                }

                Node temp = Head;

                for (int i = 1; i < position - 1; i++)
                {
                    temp = temp.Next;
                }

                newNode.Next = temp.Next;
                temp.Next = newNode;
                _size++;
            }

            public void DeleteLast()
            {
                if (IsEmpty())
                { return; }

                Node temp = Head;

                for (int i = 1; i <= _size - 1; i++)
                {
                    temp = temp.Next;
                }

                temp.Next = temp.Next.Next;
                _size--;
            }

        }
        static void Main(string[] args)
        {
            //LinkedList linkedList = new LinkedList();

            //linkedList.AddLast(1);
            //linkedList.AddLast(2);
            //linkedList.AddLast(3);

            //linkedList.AddFirst(777);
            //linkedList.AddFirst(992);

            //linkedList.AddPosition(3, 111);

            //linkedList.AddPosition(10, 888);

            //linkedList.AddPosition(11000, 11111112);

            //linkedList.ShowElements();

            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Show();

            Console.WriteLine("==============");

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine("=================");

            queue.Show();

            Console.WriteLine(queue.Peek());
        }
    }
}