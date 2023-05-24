using System.Data;

namespace Methods
{
    //struct
    //public struct Test
    //{
    //    void test()
    //    {

    //    }
    //}

    //class
    //class test2
    //{
    //    void test()
    //    {

    //    }

    //}

    public class Person
    {
        public bool isRetired(byte age)
        {
            if (age > 65)
            {
                return true;
            }

            return false;
        }

        public string GetFullName(string name, string surname)
        {
            string fullName = name + " " + surname;
            return fullName;
            //return name + " " + surname;
        }
    }

    internal class Program
    {
        #region
        public static int Sum(int a, int b) //method signature
        {
            int sum = a + b;  //method body
            return sum;
        }

        //not return value, not parameter
        public static void version1()
        {

        }

        //not return value, parameter
        private static void version2(int a, string b, bool c)
        {

        }

        //return value, not parameter
        public static string version3()
        {
            string message = "Hello world!";
            return message;
        }

        //return value, parameter
        private static bool isRetired(byte age)
        {
            if (age > 65)
            {
                return true;
            }

            return false;
        }

        // optional parameters
        private static int Vurma(int a, int b = 9, int c = 10)
        {
            int vurma = a * b * c;
            return vurma;
        }

        private static void test()
        {

        }

        private static string GetStringFromConsole(string message)
        {
            Console.Write(message);
            string username = Console.ReadLine();
            Console.WriteLine();

            return username;
        }

        private static void WriteErrorMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("----------------------------------------");
        }

        private static void WriteSuccessMessage(string message, string username)
        {
            Console.WriteLine(message + " " + username);
        }

        private static bool CheckEquality(string firstString, string secondString, ref int attemptCount, string message)
        {
            if (!firstString.Equals(secondString))
            {
                WriteErrorMessage(message);
                attemptCount--;
                return false;
            }

            return true;
        }

        #endregion

        public static double CalculateRoundArea(in double PI, double radius)
        {
            //area  = PI * Math.Pow(radius, 2);
            double area = PI * radius * radius;
            Console.WriteLine(area);
            return Math.Round(area, 2);
        }

        public static int Sum(int first, int second, int third)
        {
            return first + second + third;
        }

        public static int Sum(int first, int second, int third, int fourth)
        {
            return first + second + third + fourth;
        }

        public static int Sum(int first, int second, int third, int fourth, int fifth)
        {
            return first + second + third + fourth + fifth;
        }

        public static int Sum(int a)
        {
            return a + 1;
        }

        public static double Sum(double a)
        {
            return a + 0.1d;
        }

        static void Main(string[] args)
        {

            #region 22.05.2023
            //version1();


            //int sum = Sum(1, 2);

            //if (sum > 100)
            //{
            //    Console.WriteLine("Hello, World!");
            //}
            //else
            //{
            //    Console.WriteLine("World, Hello");
            //}

            //int vurma = Vurma(9);

            //Console.WriteLine(vurma);


            //Person person = new Person();
            //bool isRetired = person.isRetired(20);

            //string fullName = person.GetFullName("Thomas", "Edison");

            //if (isRetired)
            //    Console.WriteLine(fullName + " is retired");
            //else
            //    Console.WriteLine(fullName + " is not retired");

            //string username = "test";
            //string password = "1234";

            //string userInsertedUsername = string.Empty;
            //string userInsertedPassword = string.Empty;

            //int attemptCount = 3;
            //bool isCorrectUsername = false;
            //string message = string.Empty;

            //while (attemptCount > 0)
            //{
            //    if (!isCorrectUsername)
            //    {
            //        message = "Enter username : ";
            //        userInsertedUsername = GetStringFromConsole(message);
            //    }

            //    if (!isCorrectUsername)
            //    {
            //        message = "Inserted username is incorrect. Please insert again!";
            //        bool checkUsername = CheckEquality(username, userInsertedUsername, ref attemptCount, message);
            //        if (!checkUsername)
            //        {
            //            continue;
            //        }
            //    }

            //    isCorrectUsername = true;

            //    message = "Please enter your password : ";
            //    userInsertedPassword = GetStringFromConsole(message);

            //    message = "Your password is incorrect. Please insert again!";
            //    bool checkPassword = CheckEquality(password, userInsertedPassword, ref attemptCount, message);
            //    if (!checkPassword)
            //    {
            //        continue;
            //    }

            //    message = "Welcome";
            //    WriteSuccessMessage(message, username);
            //    break;
            //}
            #endregion

            #region 24.05.2023

            //int sum = Sum(21, 23, 45);

            // non trailing named arguments
            //int sum2 = Sum(first: 21, third: 54, second: 32);
            //Console.WriteLine(sum2);

            // in keyword
            //double area = CalculateRoundArea(Math.PI, 4);
            //Console.WriteLine(area);
            //int a = 10, b = 20;

            //TestMethod("Before", a, b);

            //static void TestMethod(string message, int a, int b)
            //{
            //    a = 20;
            //    b = 30;
            //    Console.WriteLine(message);
            //}

            //TestMethod("After", a, b);

            //method overloading

            //int sum = Sum(1, 3, 4);

            //var sum2 = Sum(2.1);

            //Console.WriteLine(SumArrange(10, 20));

            // ref and out ref = reference

            //int a = 5;

            //ref int b = ref a;

            double per = CalculateSalaryPercent(out double salary, out double percentage, 22, true, true);

            Console.WriteLine("Salary " + salary);
            Console.WriteLine("Percentage " + per);

            #endregion



        }

        public static double CalculateSalaryPercent(out double salary, out double percentage, int age, bool isBorder, bool isResident)
        {
            double firstSalary = salary = 300;
            percentage = 0;

            if (age < 25)
                salary += 100;

            if (isBorder)
                salary += 200;

            if (!isResident)
                salary += 300;

            return ((salary - firstSalary) / firstSalary) * 100;
        }

        public static void testConsole(int a = 0)
        {
            Console.WriteLine("Hello");
            if (a < 3)
            {
                testConsole(++a);
            }
            Console.WriteLine("World");
        }

        public static int SumArrange(int start, int end)
        {
            //int sum = 0;

            //for (int i = start; i < end; i++)
            //{
            //    if (i % 5 == 0)
            //        sum += i;
            //}

            //return sum;

            if (start % 5 == 0)
                return start + SumArrange(++start, end);
            if (start < end)
                return SumArrange(++start, end);
            else
                return 0;
        }
    }
}