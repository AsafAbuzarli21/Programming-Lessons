using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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

            //int[] arr = new int[10];
            //arr[0] = 1;
            //arr[1] = 5;
            //arr[2] = 6;

            //arr[3] = "dsfjsd";

            //strong typed
            //ArrayList arrList = new ArrayList();


            //Console.WriteLine(arrList.IsFixedSize);

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


            //Queue
            Queue<int> ints = new Queue<int>();

            //Stack
            //HashTable
            //Dictionary<T,K>


            CustomList<int> customList = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);

            customList.InsertAt(6, 2);

            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList[i]);
            }



        }


    }

    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public byte Age { get; set; } = 0;
    }
}