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

        static void Main(string[] args)
        {

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

            string username = "test";
            string password = "1234";

            string userInsertedUsername = string.Empty;
            string userInsertedPassword = string.Empty;

            int attemptCount = 3;
            bool isCorrectUsername = false;
            string message = string.Empty;

            while (attemptCount > 0)
            {
                if (!isCorrectUsername)
                {
                    message = "Enter username : ";
                    userInsertedUsername = GetStringFromConsole(message);
                }

                if(!isCorrectUsername)
                {
                    message = "Inserted username is incorrect. Please insert again!";
                    bool checkUsername = CheckEquality(username, userInsertedUsername, ref attemptCount, message);
                    if (!checkUsername)
                    {
                        continue;
                    }
                }

                isCorrectUsername = true;

                message = "Please enter your password : ";
                userInsertedPassword = GetStringFromConsole(message);

                message = "Your password is incorrect. Please insert again!";
                bool checkPassword = CheckEquality(password, userInsertedPassword, ref attemptCount, message);
                if (!checkPassword)
                {
                    continue;
                }

                message = "Welcome";
                WriteSuccessMessage(message, username);
                break;
            }
        }
    }