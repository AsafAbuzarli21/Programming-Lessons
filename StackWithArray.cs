public class CreateStack
            {

                    //LIFO
                    //1
                    //5 1
                    //3 5 1
                    //4 3 5 1
                    //2 4 3 5 1

              int[] stack;
              int top = -1; //empty
                public CreateStack(int size)
                {
                    stack = new int[size];                
                }

                public bool Empty()
                {
                    return top == -1;
                }
                public bool Full()
                {
                    return top == stack.Length - 1;
                }
         
                    public void Push(int pushedElement)
				{
                        if(Full() && stack.Length != 0 )
                    {
                        Console.WriteLine("Stack doludur");
                        return;
                    }
                       stack[++top] = pushedElement;
                    Console.Write(pushedElement + " ");
                    
                   
                    }
                    public int Pop()
                    {
                     if(Empty() && stack.Length != 0)
                    {
                        Console.WriteLine("Stack bosdur");
                        return -1;
                    }

                    int poppedElement = stack[top--];                    
                    
                    Console.Write(poppedElement + " ");
                    return poppedElement;
                 }

            }

            static void Main(string[] args)
            {
                
				try
				{
                    Console.Write("Olcunu daxil et: ");
					int size = Convert.ToInt32(Console.ReadLine());
					CreateStack createStack = new CreateStack(size);

                   
					createStack.Push(1);
					createStack.Push(2);
					createStack.Push(3);
					createStack.Push(4);

                    Console.WriteLine();

                    Console.Write("Cixan ededler:  ");
                    createStack.Pop();
					createStack.Pop();


				}
				catch (Exception)
				{
                    
					Console.WriteLine("Daxil etdiyiniz olcu dogru deyil.");
				}
				



			}