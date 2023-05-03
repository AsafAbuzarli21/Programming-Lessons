using System.Linq.Expressions;

namespace Lesson_4____Management_Instruction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If - else

            //int a = 10; int b = 20;


            //if (a == b)
            //{
            //    Console.WriteLine(" a is equal b");
            //}
            //else
            //{
            //    Console.WriteLine(" a is not equal b");
            //}

            //if (a % 2 == 0)
            //    Console.WriteLine(" a cutdur");
            //else
            //    Console.WriteLine(" a tekdir");

            //if (a > b)
            //{
            //    Console.WriteLine(" a is greater than b");
            //}
            //else if (a > b)
            //{
            //    Console.WriteLine(" b is greater than a");
            //}
            //else
            //{
            //    Console.WriteLine(" a is equal b");
            //}


            //if(b / 3 > 2)
            //{
            //    Console.WriteLine(a);
            //}

            //bool a = true, b = false, c = true;

            //bool d = a ^ b & c;  // ||

            //// ^

            //int a = 36;

            //if (a % 4 == 0)
            //{
            //    if (a % 9 == 0)
            //    {

            //    }
            //}

            // && - hemde
            //if (a % 4 == 0 && a % 9 == 0)
            //{
            //    Console.WriteLine("This number divides 4 and 9");
            //}
            //else
            //{

            //}

            // || - ya ya da
            //if (a % 4 == 0 || a % 9 == 0)
            //{
            //    Console.WriteLine("This number divides 4 or 9");
            //}

            #endregion

            //int a = 4;
            //bool msg;

            //switch (a)
            //{
            //    case 4 when a % 2 != 0:
            //        msg = true;
            //        break;
            //    case 1:
            //        msg = false;
            //        break;
            //    default:
            //        msg = true;
            //        break;
            //}

            //string message = a switch
            //{
            //    0 => message = "zero",
            //    1 => "zero",
            //    _ => "None of them"
            //};

            //Console.WriteLine(msg);

            //var dayOfWeek = DateTime.Now.DayOfWeek;


            //switch (dayOfWeek)
            // {
            //     case DayOfWeek.Sunday when (int)DayOfWeek.Sunday % 2 == 0:
            //         Console.WriteLine("Heftenin cut gunudur");
            //         break;
            //     case DayOfWeek.Monday when (int)DayOfWeek.Sunday % 2 == 0:
            //         Console.WriteLine("Heftenin cut gunudur");
            //         break;
            //     case DayOfWeek.Saturday :
            //         Console.WriteLine("Heftenin cut gunudur");
            //         break;
            // }


            //   Don`t repeat yourself  //


            //switch (dayOfWeek)
            //{
            //    case DayOfWeek.Sunday:
            //   even:
            //        Console.WriteLine("Write penalty");
            //        break;
            //    case DayOfWeek.Monday:
            //        goto even;

            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("Heftenin cut gunudur");
            //        break;
            //}

            //int a = 10;

            //string message = a switch
            //{
            //    0 when a > 3 => message = "zero",
            //    1 => message ="one",
            //    _ => "None of them"
            //};

            (int age, string name, bool gender, string surname) = (2, "Jhon", true,"Adam");

            switch (name, age)
            {
                case ("Jhon", 20) when age > 10:
                    Console.WriteLine($"Jhon surname is {surname}");
                    break;
                case ("Jhon", 2) when age < 10:
                    Console.WriteLine($"Jhon is less than 10 age. Jhon surname is {surname}");
                    break;
            }

        }
    }
}