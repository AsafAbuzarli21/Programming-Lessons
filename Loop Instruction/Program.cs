using System.Security.Cryptography;

namespace Loop_Instruction
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

            b:

            //break -  
            //continue - 
            //goto
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


            for (int i = 1; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                    goto b;
                }
            }

        }
    }
}