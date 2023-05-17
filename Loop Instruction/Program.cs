using System.Runtime.InteropServices;

namespace Loop_Instruction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lesson Notes

            //1-den 10 a qeder ededler
            //1-den 10 a qeder ededler (10 da daxil)
            //int i = 0;

            //for (i = 0; i <= 10;)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //for (int i = 0; i < 10; i++)
            //    Console.WriteLine(i);

            //for (int i = 0;i < 10; i++) 
            //    Console.WriteLine(i);

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 10, j = 2; i >= j; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 9; j >= 0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int a = 10;
            //bool iteration = true;

            //while (a > 50 && a < 100)
            //{
            //    if (a <= 0)
            //        iteration = !iteration;

            //    Console.WriteLine(a);
            //    a--;
            //}

            //while (true)
            //    Console.WriteLine("test");

            //while (true) ;

            //int a = 0;
            //bool i = true;

            //do
            //{
            //    if (a > 10)
            //        i = !i;

            //    Console.WriteLine("test " + a);
            //    a++;
            //}
            //while (false);

            //do
            //    Console.WriteLine("test " + a);
            //while (false);

            //do { }
            //while (true);


            //foreach (int x in Enumerable.Range(0,100))
            //{
            //    Console.WriteLine(x);
            //}



            //break -  
            //continue - 
            //goto - 
            //return

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        if (j % 9 == 0)
            //            break;
            //        Console.WriteLine(j);
            //    }
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 10 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //b:

            //    for (int i = 1; i < 100; i++)
            //    {
            //        a:
            //        if (i % 10 == 0)
            //        {
            //            Console.WriteLine(i);
            //            goto b;
            //        }
            //    }

            #endregion

            #region 12.05.2023
            #region Task 1 - Insert 10 numbers and find sum of them

            //int sum = 0, n;

            //for (int i = 1; i <= 10; i++)
            //{
            //    n = int.Parse(Console.ReadLine());
            //    sum += n;
            //}

            //Console.WriteLine("Sum : " + sum);

            #endregion

            #region Task 2 - Insert numbers and find sum of them
            //Console.WriteLine("Insert a number :");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            //Console.WriteLine($"Insert {n} numbers :");

            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    sum += num;

            //}

            //Console.WriteLine($"Sum of this numbers is {sum}");
            #endregion

            #region Task 3 - Multiplication table

            //int n = 10;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //    Console.WriteLine("-----------------------");
            //}

            #endregion

            #region Task 4 - Find the sum of the numbers from 0 to entered number

            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = 0; i < n; i++)
            //    sum += i;

            //Console.WriteLine("Sum : " + sum);

            //int sum2 = n * (n + 1) / 2 - n;
            //Console.WriteLine("sum2 : " + sum2);

            #endregion

            #region Task 5 - Get a number and create a triangle

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write(j);
            //    Console.WriteLine();
            //}

            #endregion

            #region Task 6 - Get a number and create a triangle

            //int n = int.Parse(Console.ReadLine());
            //int iteration = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(iteration + " ");
            //        iteration++;
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Task 7 - Draw triangles with *

            //int n = 10;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = n; k > n - i; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < n; i++)
            //{
            //    for (int k = n; k > n - i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

            #region 15.05.2023
            //Console.WriteLine("Please add one number :");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    sum += i % 2 == 0 ? 0 : i;

            //    //if (i % 2 == 1)
            //    //    sum += i;
            //}

            //Console.WriteLine("Sum of odd numbers " + sum);



            //int n = 10, iteration = 1;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(iteration + " ");
            //        iteration++;
            //    }
            //    Console.WriteLine();
            //}

            //int n = 10;


            //for (int i = 0; i < n; i++)
            //{
            //    for (int k = n; k > n - i; k--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            
        }
    }
}