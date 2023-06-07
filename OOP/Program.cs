using OOP2;
using static OOP.MyClass;

namespace OOP
{

    public class MyClass
    {
        //nested class
        //public class MyClass2
        //{

        //}


    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }

    public class Car
    {
        //class members
        //indexer
        //method
        //fields

        string model;
        string marka;
        int wheelCount;
        string color;
        bool isAutomatic = true;
        string ipAddress = "127.1.1.0";

        public string TestProperty { get; set; }

        //property
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                this.model = value;
                this.
                model = value;
            }
        }

        public int WheelCount
        {
            get
            {
                return wheelCount * 4;
            }
            set
            {

            }
        }

        //Read write property
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        //Readonly property
        public bool IsAutomatic
        {
            get
            {
                return isAutomatic;
            }
        }





        public void CarModel()
        {
            Console.WriteLine("Car model is" + model);
        }

        public void CarInfo()
        {
            Console.WriteLine($"Car marka is {marka}.\nColor is {color}.\nCar model is {model}.");
        }
    }

    public class Math
    {
        //field  => access modifier + type + name (+ assign operator + value)
        //access modifier => public, private
        //private int a = 10;
        //public int b;

        public int a;

        string name;
        int c;
        int b;

        //method encapsulation
        public string NameGet()
        {
            return name;
        }

        public void NameSet(string name)
        {
            this.name = name;
        }

        //property encapsulation
        //property
        //1. Type must be same with field type
        //2. Name must be same with field
        //full property
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        //read only property
        //public int A
        //{
        //    get
        //    {
        //        return a;
        //    }
        //}

        //write only property
        //public int A
        //{
        //    set
        //    {
        //        a = value;
        //    }
        //}

        //prop
        public int C { get; set; }

        //computed properties
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area
        {
            get
            {
                return Width * Height;
            }
        }

        //ref readonly property
        int s = 10;
        public ref readonly int S => ref s;

        //Auto property initializer
        public int Age { get; set; } = 20;

        //Expression bodied properties
        public int Age2 => 20;

        //method
        public void X()
        {

        }

        //indexer
        public int this[int a]
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public Math Clone()
        {
            return (Math)MemberwiseClone();
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            #region 05.06.2023
            //Car bmw = new Car();

            //bmw.Model = "Test";

            //Rectangle rectangle = new Rectangle();

            //rectangle.Width = 10;
            //rectangle.Height = 10;

            //Console.WriteLine(rectangle.Area);
            #endregion

            #region 07.06.2023

            //field
            //Math math = new Math();
            //math.b = 10;
            //Console.WriteLine(math.b);
            //Math math2 = new Math();
            //math2.b = 40;
            //Console.WriteLine(math2.b);

            //property
            //int.TryParse(Console.ReadLine(),out int a);
            //object o = a;
            //Math math = new Math();
            //math.A = a;
            //Console.WriteLine(math.A);
            //math.A = 2;
            //math.a = 3;
            //math.NameSet("Adam");
            //Console.WriteLine(math.NameGet());

            //Math math = new Math();

            //math.Width = 100;
            //math.Height = 100;

            //Console.WriteLine(math.Area);

            //property signature
            //summary
            //this
            //Object copies
            //referance
            //Encapsulation  -=> OOP principle
            //

            Math math = new  Math();

            Math math2 = math;

            math2.Age = 5;

            int b = 10;

            int a = b;

            Math math3 = math.Clone();
            math3.Age = 10;

            Console.WriteLine(math.Age);


            #endregion
        }
    }
}

namespace OOP3
{
    internal class Test
    {
    }
}