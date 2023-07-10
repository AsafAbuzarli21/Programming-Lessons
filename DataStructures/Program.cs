namespace DataStructures
{
    internal class Program
    {
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

        //public class Queue
        //{
        //    public Node Head;
        //    public Node Tail;

        //    public Queue()
        //    {
        //        Head = null;
        //        Tail = null;
        //    }

        //    public void Show()
        //    {
        //        if (Head == null)
        //        {
        //            Console.WriteLine("List is empty");
        //            return;
        //        }

        //        Node temp = Head;

        //        while (temp != null)
        //        {
        //            Console.WriteLine(temp.Data);
        //            temp = temp.Next;
        //        }
        //    }

        //    public void Enqueue(int data)
        //    {
        //        var newNode = new Node(data);

        //        if (Head == null)
        //        {
        //            Head = newNode;
        //            Tail = newNode;
        //            return;
        //        }

        //        Tail.Next = newNode;
        //        Tail = newNode;

        //    }

        //    public int Dequeue()
        //    {
        //        int peek;

        //        if (Head == null)
        //        {
        //            return -1;
        //        }

        //        peek = Head.Data;
        //        Head = Head.Next;

        //        return peek;
        //    }

        //    public int Peek()
        //    {
        //        if (Head == null)
        //        {
        //            return -1;
        //        }

        //        return Head.Data;
        //    }

        //    public bool IsEmpty()
        //    {
        //        if (Head == null)
        //            return true;

        //        return false;
        //    }
        //}

        //public class Stack
        //{
        //    public Node Top;

        //    public Stack()
        //    {
        //        Top = null;
        //    }

        //    public void Show()
        //    {
        //        if (Top == null)
        //        {
        //            Console.WriteLine("List is empty");
        //            return;
        //        }

        //        Node temp = Top;

        //        while (temp != null)
        //        {
        //            Console.WriteLine(temp.Data);
        //            temp = temp.Next;
        //        }
        //    }

        //    public void Push(int data)
        //    {
        //        var newNode = new Node(data);

        //        if (Top == null)
        //        {
        //            Top = newNode;
        //            return;
        //        }

        //        newNode.Next = Top;
        //        Top = newNode;
        //    }

        //    public int Pop()
        //    {
        //        int peek;

        //        if (Top == null)
        //        {
        //            return -1;
        //        }

        //        peek = Top.Data;
        //        Top = Top.Next;

        //        return peek;
        //    }

        //    public int Peek()
        //    {
        //        if (Top == null)
        //        {
        //            return -1;
        //        }

        //        return Top.Data;
        //    }

        //    public bool IsEmpty()
        //    {
        //        return Top == null;
        //    }
        //}

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

        public class DoubleLinkedList
        {
            public Node Head;
            int _size = 0;

            public Node Tail;

            public DoubleLinkedList()
            {
                Head = null;
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
                    Head = newNode;
                    _size++;
                    return;
                }

                Node temp = Head;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = newNode;
                newNode.Previous = temp;
                _size++;
            }
            
            public void DeleteFirst()
            {
                if (IsEmpty())
                {
                    return;
                }

                if (Head.Next == null)
                {
                    Head = null;
                    return;
                }

                Head = Head.Next;
                Head.Next.Previous = null;

            }
        }
        /*mine*/
        public class Stack<T>
        {
            public T[] array;
            public int top;

            public Stack(int capacity)
            {
                array = new T[capacity];
                top = -1;
            }
            public bool IsEmpty() 
            {
               return array.Length == 0;
            }
            public bool IsFull()
            {
                return array.Length == array.Length;
            }
            public void Show()
            {
                if(IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                for(int i = top; i >= 0; i--)
                {
                    Console.WriteLine(array[i]);
                }   

            }
            public void Push (T item)
            {
              if(!IsFull())
              {
                    Console.WriteLine("Stack is full");
              }
                array[++top] = item;
            }
            public T Pop()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                }
                Console.WriteLine($"Poped element - {top + 1}");
                T item = array[top];
                array[top--] = default(T);
                return item;
            }
            public T Peek()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                }
                return array[top];
            }
            
        }
        public class Queue<T>
        {
            public T[] array;
            public int head;
            public int tail;
            public int count;
            public Queue(int capacity)
            {
                array = new T[capacity];
                head = 0;
                tail = -1;
                count = 0;
            }
            public bool IsEmpty()
            {
                return count == 0;
            }
            public bool IsFull()
            {
                return count == array.Length;
            }
            public void Enqueue(T item)
            {
                tail = (tail + 1) % array.Length;
                array[tail] = item;
                count++;
            }
            public T Dequeue()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Queue is empty.");
                }
                T item = array[head];
                head = (head + 1) % array.Length;
                count--;
                return item;
            }
            public void Show()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Queue is empty"); return;
                }
                int current = head;
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(array[current]);
                    current = (current + 1) % array.Length;
                }
            }
            public T Peek()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Queue is empty."); 
                }
                return array[head];
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

            //Queue queue = new Queue();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //queue.Show();

            //Console.WriteLine("==============");

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());

            //Console.WriteLine("=================");

            //queue.Show();

            //Console.WriteLine(queue.Peek());

            //DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
            //doubleLinkedList.AddLast(1);
            //doubleLinkedList.AddLast(2);
            //doubleLinkedList.AddLast(3);
            //doubleLinkedList.AddLast(4);
            //doubleLinkedList.AddLast(5);
            //doubleLinkedList.Show();
            //Console.WriteLine("                   ");

           //Stack<int> stack = new Stack<int> (5);
           //stack.Push (1);
           // stack.Push (2);
           // stack.Push (3);
           // stack.Push (4);
           // stack.Push (5);
           // stack.Show();
           //Console.WriteLine("                        ");
           //stack.Pop();
           //Console.WriteLine("                        ");
           //stack.Show ();
           //Console.WriteLine(stack.Peek());

            //Queue<int> queue = new Queue<int> (5);
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Show();
            //Console.WriteLine("            ");
            ////queue.Dequeue();
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine("            ");
            //queue.Show();
        }
    }
}