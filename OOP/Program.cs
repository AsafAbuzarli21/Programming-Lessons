﻿using System.Drawing;

namespace OOP
{
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

    public class Car2
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

        //Method overloading
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }

    public class Person
    {
        int age;
        string name;

        //auto property initializer
        //init - initialize
        public string Surname { get; init; }

        public int Age
        {
            get
            {
                return age;
            }
            set
            { age = value; }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }
    }

    public record Person2
    {
        int a;
        string name;
        string surname;

        public string Surname { get; set; }
        public int Age { get; set; }

    }

    public class MyClass
    {
        int test;
        //default constructor
        public MyClass()
        {
            Console.WriteLine("First constructor trigged");
        }

        //static constructor
        static MyClass()
        {
            Console.WriteLine("Static constructor");
        }

        //parametrli construktor
        public MyClass(int id) : this()
        {
            Id = id;
            //Console.WriteLine("Second constructor trigged");
        }

        public MyClass(int id, string name) : this(id)
        {
            Id = id;
            Name = name;
        }

        //tilda - ~
        //deconstructor
        //Garbage Collection
        ~MyClass()
        {
            Console.WriteLine("Object deleteddd....");
        }

        public int Id { get; set; }
        public string Name { get; set; }


        public void X()
        {
            var obj = new MyClass();

        }

        public void Deconstruct(out int id, out string name)
        {
            id = Id;
            name = Name;
        }
    }

    //Nominal records
    public record MyRecord
    {
        public int age { get; init; }
        public string Name { get; init; }

        //public MyRecord With(int age)
        //{
        //    //this.age = age;
        //    return this;
        //}
    }

    public class TestClass2
    {
        //readonly
        public readonly int Id = 45;

        //constant
        public const int TestField = 21;

        //readonly property
        public int MyProperty { get; } = 10;
        //public string MyProperty2 { get; set; }

        public TestClass2()
        {

        }

        public TestClass2(int id, int testField)
        {
            Id = id;
            //TestField = testField;
        }

        public TestClass2(int myProperty1, string myProperty2)
        {
            this.MyProperty = myProperty1;
            //MyProperty2 = myProperty2;

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

            //Math math = new  Math();

            //Math math2 = math;

            //math2.Age = 5;

            //int b = 10;

            //int a = b;

            //Math math3 = math.Clone();
            //math3.Age = 10;

            //Console.WriteLine(math.Age);


            #endregion

            #region 09.06.2023

            //init only property

            //Person person = new Person()
            //{
            //    Surname = "Adam"
            //};

            //Person2 person2 = new Person2()
            //{
            //    Surname = "test",
            //    Age = 5
            //};

            //MyClass clas1 = new MyClass()
            //{
            //    MyProperty = 1
            //};

            //MyClass clas2 = new MyClass()
            //{
            //    MyProperty = 1
            //};

            //Console.WriteLine(clas1.Equals(clas2));

            //MyClass clas3 = clas1;

            //Console.WriteLine(clas3.Equals(clas1));

            //MyRecord rec1 = new MyRecord()
            //{
            //    age = 1
            //};

            //MyRecord rec2 = new MyRecord()
            //{
            //    age = 1
            //};

            ////MyRecord rec4 = rec1.With(20);

            //MyRecord rec3 = rec1 with { age = 3 };

            //Console.WriteLine("Rec 1 " + rec1.age);
            //Console.WriteLine("Rec 2 " + rec2.age);
            //Console.WriteLine("Rec 3 " + rec3.age);
            //Console.WriteLine("Rec 4 " + rec4.age);

            //Console.WriteLine(rec1.Equals(rec2));


            //Constructor

            //MyClass class1 = new MyClass();

            //MyClass class2 = new MyClass(15);

            //MyClass class3 = new MyClass(20, "Test");

            //MyClass class4 = new MyClass()
            //{
            //    Id = 10,
            //    Name = "Test"
            //};

            //Deconstructor
            //Deconstrut method
            //static constructor

            //MyClass clas1 = new MyClass(30);

            //clas1 = null;

            //GC.Collect();

            //Console.ReadLine();


            //Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Steve", "Jobs");

            ////tuple
            //(int id, string name) = clas1;

            //Console.WriteLine(id);
            //Console.WriteLine(name);

            //MyClass class1 = new MyClass();

            //MyClass class2 = new MyClass();


            #endregion

            #region 12.06.2023 - Inheritance

            //TestRecord rec = new TestRecord("Test");

            //rec.WriteMessage();


            //Inheritance -miras
            //base class
            //derived/child class

            //BMW bmw = new BMW("M5");
            //bmw.Info();

            //bmw.GetHashCode();

            ////byte b = 10;
            ////int a = b;

            ////byte c = a;

            //Baba baba = new Baba();
            ////baba.Surname

            //Usaq usaq = new Usaq();


            //Hen hen = new Hen();
            //hen.Fly();

            //WorldBank bank = new WorldBank(1);
            //var WMoney = bank.CalculatePercent(100);
            //Console.WriteLine(WMoney);

            //AzerbaijanBank azerbaijanBank = new AzerbaijanBank(1);
            //var AZEMoney = azerbaijanBank.CalculatePercent(100);

            //Console.WriteLine(AZEMoney);


            #endregion

            #region 14.06.2023 - Polymorphism

            //Polymorphism = poly - coxlu, morphism - forma

            //B b = new B();

            //A a = new B();

            //C c = new C();

            ////explicit casting
            //B b2 = (B)c;
            //B b = new B();


            //compile time error
            //C c2 = b;

            //implicit casting
            //A a2 = c;

            //A a3 = c as A;

            ////run time error
            ////C c3 = b as C;

            //if (b is C)
            //{
            //    C c3 = b as C;
            //}
            //else if(c is B)
            //{
            //    B b4 = c as B;
            //}

            //Static Polymorphism

            //Math math = new Math();

            //math.Sum(10, 8);

            //Dynamic Polymorphism

            //A a = new A();
            //a.X()


            // ___B__  is a ___A_  // Association
            // Qualification  has a Salary

            #endregion

            #region 16.06.2023 - Abstraction

            //readonly const
            //TestClass test = new TestClass(myProperty1: 21, myProperty2: "test");

            //Console.WriteLine(test.MyProperty);

            //TestClass test2 = new TestClass(id: 45);

            //Console.WriteLine(test2.MyProperty);

            //Console.WriteLine(test2.Id);

            //TestClass test3 = new TestClass();

            //Console.WriteLine(test3.Id);

            //const - constant


            //Abstraction


            //TestClass testClass = new();


            //TestAbstractClass testAbstractClass = new TestClass();
            //testAbstractClass.TestMethod();


            //Computer computer = new Computer();

            //Adapter adapter = new Computer();

            //adapter.Charge();

            TestInterface testInterface = new TestInterface();

            ITestInterface testInterface1 = new TestInterface();

           // testInterface1.

            #endregion
        }
    }

    interface ITestInterface2
    {
        void Y();

        void Z();

       // void x();
    }

    interface ITestInterface
    {
        string Name { get; set; }
        int Id { get; set; }

        void x();

        void WriteConsole(string message);
    }

    public class TestInterface : ITestInterface, ITestInterface2
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void WriteConsole(string message)
        {
            throw new NotImplementedException();
        }

        void ITestInterface.x()
        {
            throw new NotImplementedException();
        }

        //public void ITestInterface2.x()
        //{
        //    throw new NotImplementedException();
        //}

        public void Y()
        {
            throw new NotImplementedException();
        }

        public void Z()
        {
            throw new NotImplementedException();
        }
    }


    public abstract class TestAbstractClass2
    {
        public string Surname { get; set; }


        public abstract byte Age { get; set; }
        public abstract void K();
    }

    public abstract class TestAbstractClass : TestAbstractClass2
    {
        //non-abstract members
        public int Id { get; set; }

        public string Name { get; set; }

        public void Method()
        {
            Console.WriteLine("This is method");
        }

        //abstract members
        public abstract int MyProperty { get; set; }
        public abstract void TestMethod();
    }

    public class TestClass : TestAbstractClass
    {
        public override int MyProperty
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public override byte Age
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public override void K()
        {
            throw new NotImplementedException();
        }

        public override void TestMethod()
        {
            Console.WriteLine("Tis is test method");
        }


        public void X()
        {

        }

        public void Y()
        {

        }

    }


    public abstract class Adapter
    {
        public abstract string Electric { get; set; }

        public abstract void Charge();
    }

    public class Computer : Adapter
    {
        public override void Charge()
        {
            Console.WriteLine("Computer is charging....");
        }

        public override string Electric { get; set; }
    }


    public class UserOperation : UserProcess
    {
        public string UserId { get; set; }

        public UserOperation()
        {

        }

        public UserOperation(string userId)
        {
            UserId = userId;
        }

    }

    public class UserProcess : UserValidation
    {
        public int AddUser(User user)
        {
            return 66;
        }

        public int UpdateUser(User user)
        {
            return 66;
        }

        public bool RemoveUser(int id)
        {
            return true;
        }

    }

    public class UserValidation
    {
        public bool ValidateUser(User user)
        {
            return false;
        }
    }

    public class User
    {

    }


    //Object
    public class BoyukBaba
    {
        public string surname { get; set; }
    }

    public class Baba : BoyukBaba
    {

    }

    public class Ata : Baba
    {

    }

    public class Ana : Ata
    {
        public string Surname { get; set; }
    }

    public class Usaq : Ana
    {
        //name hiding
        public new string Surname { get; set; } = string.Empty;
    }

    public class Bird
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Voice { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine("I am fling......");
        }
    }

    public class Hen : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("I cant fly...");
        }
    }

    public class Eagle : Bird
    {

    }

    public class Parrot : Bird
    {

    }

    //base
    public class Car
    {
        public Car(string model)
        {
            this.Model = model;
        }

        public string Model { get; set; }
        public int WheelCount { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public void Info()
        {
            Console.WriteLine("Model - " + Model);
        }
    }

    //derived
    public class BMW : Car
    {

        public BMW(string model) : base(model)
        {
            Model = model;
        }

        public string Name { get; set; }
    }

    //child
    public class Mercedes : Car
    {
        public Mercedes(string model) : base(model)
        {
            base.Model = model;
            this.Model = model;
        }
    }

    public class Audi : Car
    {
        public Audi(string model) : base(model)
        {
        }
    }

    public record TestRecord
    {
        public string Message { get; init; }

        public TestRecord(string message)
        {
            this.Message = message;
        }

        public void WriteMessage()
        {
            Console.WriteLine(Message);
        }
    }

    public class WorldBank
    {
        //protected
        protected int percent;

        public WorldBank(int percent)
        {
            this.percent = percent;
        }

        public string Name { get; set; }

        public virtual int CalculatePercent(int money)
        {
            return money + (money * percent) / 100;
        }
    }

    public class AzerbaijanBank : WorldBank
    {
        public AzerbaijanBank(int percent) : base(percent)
        {

        }

        public override int CalculatePercent(int money)
        {
            percent = percent + 4;

            return money + (money * percent) / 100;
        }
    }

    public class TurkishBank : WorldBank
    {
        public TurkishBank(int percent) : base(percent)
        {

        }
    }

    /// <summary>
    /// This is A class
    /// </summary>
    public class A
    {
        /// <summary>
        /// this is X method
        /// </summary>
        /// <param name="message"></param>
        public virtual void X(string message)
        {

        }

        /// <summary>
        /// this is X method
        /// </summary>
        public virtual void X()
        {
            Console.WriteLine("This is base class");
        }
    }

    public class B : A
    {
        public override void X()
        {
            Console.WriteLine("This is B class");
        }
    }

    public class C : B
    {
        public override void X()
        {
            Console.WriteLine("This is C class");
        }
    }

    public class D
    {

    }

    public class Qualification
    {
        Salary _salary;

        public string? Name { get; set; }
        public Salary? Salary { get; set; }
    }

    public class Salary : ISalary
    {
        int ISalary.Value { get; set; }
        string? ISalary.Currency { get; set; }

        void ISalary.CalculateSalary()
        {

        }
    }

    public interface ISalary
    {
        int Value { get; set; }
        string? Currency { get; set; }
        void CalculateSalary();
    }
}
