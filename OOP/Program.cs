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


    internal class Program
    {
        // MyClass my = new MyClass();

        //field - sahe

        static void Main(string[] args)
        {

            //Car bmw = new Car();

            //bmw.Model = "Test";

            Rectangle rectangle = new Rectangle();

            rectangle.Width = 10;
            rectangle.Height = 10;

            Console.WriteLine(rectangle.Area);

        }
    }
}

namespace OOP3
{
    internal class Test
    {
    }
}