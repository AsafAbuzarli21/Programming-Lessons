using static Generics_Collections.Program;

namespace Generics_Collections
{

    public class CollectDataInt
    {
        public int Data { get; set; }
    }

    public class CollectDataString
    {
        public string Data { get; set; }
    }

    //T => type
    public class CollectData<T>
    {
        //generic field
        public T Value;

        public DayOfWeek2 DayOfWeek { get; set; }

        //generic property
        public T Data { get; set; }

        //generic method
        public void GetType<A>()
        {
            Console.WriteLine(typeof(T).Name);
        }
    }

    public class Program
    {
        public enum DayOfWeek2 : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Friday,
            Thursday,
            Saturday,
            Sunday
        }

        public static T GetInfo<T>()
        {
            object obj = 3;
            return (T)obj;
        }

        static void Main(string[] args)
        {
            #region Generics
            //int a = Convert.ToInt32(Console.ReadLine());

            //CollectDataInt collectDataInt = new();

            //collectDataInt.Data = a;

            //Console.WriteLine(collectDataInt.Data);

            //string b = Console.ReadLine();

            //CollectDataString collectDataString = new();

            //collectDataString.Data = b;

            //CollectData<int> collectDataInt2 = new();
            //collectDataInt2.Data = a;

            //CollectData<string> collectDataString2 = new();
            //collectDataString2.Data = b;


            //var c = GetInfo<int?>(); 
            #endregion

            //Array arr2 = new int[10];
            //Console.WriteLine(arr2.IsFixedSize);

            //Collections
            //ArrayList

            //int[] arr = new int[10]; //Array
            //arr[0] = 1;
            //arr[1] = 5;
            //arr[2] = 6;

            //Array array = arr;

            ////arr[3] = "dsfjsd";

            ////strong typed
            //ArrayList arrList = new ArrayList();


            ////Console.WriteLine(arrList.IsFixedSize);

            //arrList.AddRange(arr);

            //var b = arrList.Add(10);

            //arrList.Add("test");
            //arrList.Add(true);
            //arrList.Add(3.4);

            //int index = arrList.IndexOf(10);

            //int age = (int)arrList[index];

            //Console.WriteLine(age);

            //CollectData<string> data = new CollectData<string>();

            ////add element to the end of the array list
            //arrList.Add(data);



            //arrList.CopyTo()

            //arrList.Clear();

            //arrList.Remove(10);

            //arrList.RemoveAt(2);

            //arrList.RemoveRange(2, 4);
            //arrList.Equals("sfsd");

            //arrList.Insert(7, 42);

            //arrList.InsertRange(9, arr);

            //arrList.SetRange(5, arr);

            //arrList.

            //for (int i = 0; i < arrList.Count; i++)
            //{
            //    Console.WriteLine(arrList[i]);
            //}

            //Console.WriteLine(DayOfWeek.Sunday.ToString());

            //List
            //List<string> list = new List<string>();

            //List<Person> people = new List<Person>();

            ///type1
            //Person asaf = new Person();
            //asaf.Name = "Asaf";
            //asaf.Age = 24;

            //Person kanan = new Person();
            //kanan.Name = "Kanan";
            //kanan.Age = 24;

            //Person ayxan = new Person()
            //{
            //    Name = "Ayxan",
            //    Age = 17
            //};

            //people.Add(ayxan);
            //people.Add(kanan);
            //people.Add(asaf);

            /////type2
            //people.Add(new Person()
            //{
            //    Name = "Sahib",
            //    Age = 24
            //});

            /////type3
            //List<Person> persons = new List<Person>()
            //{
            //     new Person()
            //     {
            //         Name = "Faiq",
            //         Age = 17
            //     },
            //     new Person()
            //     {
            //         Name = "Seymur",
            //         Age = 22
            //     },
            //     new Person()
            //     {
            //         Name ="Settar",
            //         Age = 22
            //     }
            //};

            //list.ForEach(person => { });

            //var test = persons.Cast<object>();

            //var per = persons.Find(x => x.Age > 17);
            //var pers = persons.FindAll(x => x.Age > 17);




            //Company company = new Company();

            //company.Add("Faiq", 1200);
            //company.Add("Ayxan", 1300);
            //company.Add("Kenan", 1500);
            //company.Add("Sahib", 2700);

            //company.ShowEmployees();

            //double salary = company.GetSalary("Ayxan2");

            //company.UpdateEmployee("Faiq", 1900);

            //string nameOfEmployeeWithMaxSalary = company.GetEmployeeNameWithMaxSalary();

            //Console.WriteLine(nameOfEmployeeWithMaxSalary);

            //Console.WriteLine("+=============================");

            //company.RemoveEmployee("Kenan");

            //company.ShowEmployees();


            //Array arrArray = arrList.ToArray();


            //CollectData<string> collectData = new CollectData<string>();
            //collectData.Data = "Asaf";

            //CollectData<int> collectData2 = new CollectData<int>();
            //collectData2.Data = 1;

            //ArrayList arrayList = new ArrayList();
            ////arrayList.is

            //List<int> ints = new List<int>();
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //ints.Add(4);

            //ints.Add(5);
            //ints.Add(6);

            //for (int i = 0; i < ints.Count; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}

            //ints.Clear();

            //Console.WriteLine(ints.Capacity);

            // CustomList<string> list = new CustomList<string>();

            //list.Add("Asaf");
            //list.Add("Faiq");
            //list.Add("Nemet");
            //list.Add("Ayxan");
            //list.Add("Kenan");

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //CustomList<int> list = new CustomList<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);


            //list.InsertAt(2, 90);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //List<int> ints = new List<int>();

            //ints.RemoveRange
            //ints.Contains => T.Equals(item);
            //ints.CopyTo(list);
            //ints.Min            
            //ints.Max
            //ints.LastIndexOf
            //ints.IndexOf

            //Generic => Non generic

            //List<T> => ArrayList
            //Queue<T> => Queue
            //Stack<T> => Stack
            //Dictionary<Tk,Tv> => HashTable

            //Queue => FIFO => first in first out
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //foreach (int i in queue)
            //    Console.WriteLine(i);

            //Console.WriteLine("==================");

            //var item = queue.Peek();
            //Console.WriteLine(item);

            //Console.WriteLine("============");


            //var item2 = queue.Dequeue();

            //foreach (int i in queue)
            //    Console.WriteLine(i);

            //Queue queue1 = new Queue();
            //queue1.Enqueue(1);
            //queue1.Enqueue("sdfsdg");

            //Stack => LIFO => last in first out
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);

            //foreach (int i in stack)
            //    Console.WriteLine(i);

            //var peekItem = stack.Peek();
            //Console.WriteLine("Peeked item :" + peekItem);

            //stack.Clear();

            //var tryPeekItem = stack.TryPeek(out int a);
            //Console.WriteLine("Try Peeked item :" + tryPeekItem);

            //Console.WriteLine(a);

            //var item = stack.Pop();

            //stack.TryPop(out int b);

            //Console.WriteLine("=====================");

            //foreach (int i in stack)
            //    Console.WriteLine(i);

            //HashTable
            //Dictionary<T,K>
        }


    }

    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public byte Age { get; set; } = 0;
    }
}