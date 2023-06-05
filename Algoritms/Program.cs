using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Algoritms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 31.05.2023
            //input  -- array
            //output  -- array, eded
            //Definiteness – müəyyənlik
            //Correctness – doğruluq
            //Finiteness – sonluluq
            //Effectiviness – hər addımı geriyə dəyər qaytarmalıdır
            //Generality – ümumilik

            //Complexity

            //Time -- Space

            //Big - O

            //O(1)

            //int[] arr = { 2, 5, 6, 89, 0, 1 };

            //int searchedNumber = int.Parse(Console.ReadLine());
            //bool isExist = false;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == searchedNumber)
            //    {
            //        Console.WriteLine($"Searched number position is {i}");
            //        isExist = true;
            //    }
            //}

            //if (!isExist)
            //{
            //    Console.WriteLine("There is no element as given");
            //}

            //O(n)
            // Omeqa(1)

            //O(x^3)

            //Random rand = new Random();

            //int computerNumber = rand.Next(0, 100);

            //Console.WriteLine("Please enter number");

            //while (true)
            //{
            //    int num = int.Parse(Console.ReadLine());

            //    if (num > computerNumber)
            //    {
            //        Console.WriteLine("Small");
            //    }
            //    else if (num < computerNumber)
            //    {
            //        Console.WriteLine("Big");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You find the number");
            //        break;
            //    }
            //}


            //Selection sort

            //string[] mas = Console.ReadLine().Split(' ');

            //int[] arr = new int[mas.Length];

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    arr[i] = int.Parse(mas[i]);
            //}

            //var array = SelectionSort(arr);

            //foreach (int i in array)
            //{
            //    Console.Write(i + " ");
            //}



            //Bubble

            //string[] mas = Console.ReadLine().Split(' ');

            //int[] arr = new int[mas.Length];

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    arr[i] = int.Parse(mas[i]);
            //}

            //var array = BubbleSort(arr);

            //foreach (int i in array)
            //{
            //    Console.Write(i + " ");
            //}

            //Insertion sort

            //string[] mas = Console.ReadLine().Split(' ');

            //int[] arr = new int[mas.Length];

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    arr[i] = int.Parse(mas[i]);
            //}

            //var array = InsertionSort(arr);

            //foreach (int i in array)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region 02.06.2023

            //Search Algorithms

            // Linear search

            //O(n)
            //teta(1)

            //Console.WriteLine("Please insert array");
            //string[] mas = Console.ReadLine().Split(' ');

            //int[] arr = new int[mas.Length];

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    arr[i] = int.Parse(mas[i]);
            //}

            //Console.WriteLine("Please insert target number");
            //int target = int.Parse(Console.ReadLine());

            //int index = LinearSearch(arr, target);

            //string message = index == -1 ? "Target is not exist" : $"ETarget is exist. Index - {index}";

            //Console.WriteLine(message);


            //Binary Search

            //Console.WriteLine("Please insert array");
            //string[] mas = Console.ReadLine().Split(' ');

            //int[] arr = new int[mas.Length];

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    arr[i] = int.Parse(mas[i]);
            //}

            //Console.WriteLine("Please insert target number");
            //int target = int.Parse(Console.ReadLine());

            //SelectionSort(arr);

            //int index = BinarySearch(arr, target);

            //Console.WriteLine("Sorted array");
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Console.WriteLine();
            //string message = index == -1 ? "Target is not exist" : $"Target is exist. Index - {index}";

            //Console.WriteLine(message);

            //Console.WriteLine("Please insert array");
            //string[] mas = Console.ReadLine().Split(' ');

            //int[] arr = new int[mas.Length];

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    arr[i] = int.Parse(mas[i]);
            //}

            //Console.WriteLine("Please insert target number");
            //int target = int.Parse(Console.ReadLine());

            //var indexArr = FindElementCount(arr, target);
            //int count = 0;

            //if (indexArr.Length > 0)
            //{
            //    Console.WriteLine("Element indexes");
            //    for (int i = 0; i < indexArr.Length; i++)
            //    {
            //        if (indexArr[i] != -1)
            //        {
            //            Console.Write(indexArr[i] + " ");
            //            count++;
            //        }
            //    }

            //    Console.WriteLine($"Element count is {count} :");

            //}
            //else
            //    Console.WriteLine("Element is not found");


            //int dividedNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine(Divide(dividedNumber));

            #endregion

            Console.WriteLine("Please insert number of array element");

            int count = int.Parse(Console.ReadLine());

            int[] arr = new int[count];

            Console.WriteLine("Please insert array elements");
            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            SlideArrayElements(arr);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }

        public static int[] SlideArrayElements(int[] arr)
        {
            int next = 0, swap = 0;

            for (int i = 1; i < arr.Length; i++)
            {

                if (i == arr.Length - 1)
                {
                    arr[arr.Length - 1] = next ;
                    arr[0] = swap;
                }
                else if (i == 1)
                {
                    next = arr[i];
                    arr[i] = arr[i - 1];
                }
                else
                {
                    swap = arr[i];
                    arr[i] = next;
                    next = swap;
                    swap = arr[i + 1];
                }
            }

            return arr;
        }

        public static int Divide(int a)
        {
            int count = 1;
            for (int i = 1; i < a / 2; i++)
            {
                if (a / i == a % i)
                    count++;
            }

            return count;
        }

        public static string BitCode(string code)
        {
            if (!string.IsNullOrEmpty(code) && code.Length > 0)
            {
                char[] bits = new char[code.Length];

                for (int i = 0; i < code.Length; i++)
                {
                    if (i == 0)
                    {
                        if (code[i] == 0)
                            bits[i] = '0';
                        else
                            bits[i] = '1';
                    }
                    else
                    {
                        if (code[i] == code[i - 1])
                            bits[i] = '0';
                        else
                            bits[i] = '1';
                    }
                }

                return new string(bits);
            }
            else
                return null;
        }

        public static int[] FindElementCount(int[] arr, int target)
        {
            int[] indexArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    indexArr[i] = i;
                else
                    indexArr[i] = -1;
            }

            return indexArr;
        }

        public static int BinarySearch(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;

            if (arr.Length == 0)
            {
                return -1;
            }

            while (start <= end)
            {
                int middle = (start + end) / 2;

                if (arr[middle] > target)
                    end = middle - 1;
                else if (arr[middle] < target)
                    start = middle + 1;
                else
                    return middle;

            }

            return -1;
        }

        public static int LinearSearch(int[] arr, int target)
        {
            if (arr.Length == 0)
                return -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }

            return -1;
        }

        public static int[] SelectionSort(int[] array)
        {
            int minIndex = 0;

            // ( n - 1 +  n - 2 +  n - 3.....0)  n*(n-1)/2 = 0.5n2 - 0.5n O(n2)

            for (int i = 0; i < array.Length; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }

                int swap = array[i];
                array[i] = array[minIndex];
                array[minIndex] = swap;

            }

            return array;
        }

        public static int[] BubbleSort(int[] array)
        {
            int swap = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }

            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = --j;
                }

                array[j + 1] = key;

            }

            return array;
        }
    }
}