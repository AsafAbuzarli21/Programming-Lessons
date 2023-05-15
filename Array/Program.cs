
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte jhon = 28;
            //byte jane = 40;
            //byte kate = 24;


            //byte[] ages =new byte[9]; //length

            //// start with - 0
            //// end with - length - 1

            //ages[0] = 21;
            //ages[1] = 22;
            //ages[2] = 23;
            //ages[3] = 24;
            //ages[4] = 25;
            //ages[5] = 26;
            //ages[6] = 60;
            //ages[7] = 45;
            //ages[8] = 64;

            //Console.WriteLine(ages[7]);



            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            //int[] arr2 = { 1, 2, 3 };

            //var arr3 = new int[] { 4, 3, 4, 5 };

            //arr0.Length

            //int[] arr0 = new int[20];

            //arr0[0] = 21;
            //arr0[1] = 22;
            //arr0[2] = 23;
            //arr0[3] = 24;
            //arr0[4] = 25;
            //arr0[5] = 26;
            //arr0[6] = 60;
            //arr0[7] = 45;

            //for (int i = 0; i < arr0.Length; i++)
            //{
            //    Console.WriteLine($"{i} index - {arr0[i]} element");
            //}

            //string[] strs = new string[10];// { "Asaf", "Kenan", "Sahib", "Ruslan" };

            //strs[0] = "Asaf";
            //strs[1] = "Kenan";
            //strs[2] = "Sahib";
            //strs[3] = "Ruslan";

            //for (int i = 0; i < strs.Length; i++)
            //{
            //    Console.WriteLine($"{i} index - {strs[i]} element");
            //}

            //int[] arr2 = new int[100908345934579];



            //bool a;

            //bool[] boolArr = new bool[7];
            //boolArr[6] = true;
            //boolArr[3] = true;


            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            //arr[5] = 6;
            //arr[6] = 7;
            //arr[7] = 8;
            //arr[8] = 9;
            //arr[9] = 10;


            //Array arr2 = new int[10];

            //Array arr3 = Array.CreateInstance(typeof(int), 10);

            //arr2.CopyTo(arr, 0);

            //arr2 = arr.Reverse().ToArray();

            //Array.Reverse(arr2);

            //Array.Reverse(arr);

            //arr.Reverse();


            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int len = arr.Length;
            //int[] reversedArr = new int[len];

            //for (int i = 0; i < len; i++)
            //{
            //    reversedArr[len - i - 1] = arr[i];
            //}

            //for (int i = 0; i < reversedArr.Length; i++)
            //{
            //    Console.WriteLine($"index - {i} => element - {reversedArr[i]}");

            //}


            //class

            //string a = "";

            //class b = new class()

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arr5 = new int[10];
            //int[] arr6 = new int[10];

            //arr5 = arr;
            //arr5[6] = 100;

            //arr5.CopyTo(arr6, 0);
            //arr6[7] = 1000;

            //Array t = Array.CreateInstance(typeof(int),10);

            //Console.WriteLine(arr.IsFixedSize);
            //Console.WriteLine(arr.IsReadOnly);

            //Array arr1 = Array.CreateInstance(typeof(int), 10);
            //arr1.SetValue(2, 0);
            //arr1.GetValue(0);

            //Array arr2 = (Array)arr1.Clone();

            //Console.WriteLine();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr6[i]);
            //}

            //Console.WriteLine("============");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //int[,] arr = new int[2, 3];
            //int[] arr2 = new int[2];

            //arr[0, 0] = 1;
            //arr[0, 1] = 2;
            //arr[0, 2] = 3;
            //arr[1, 0] = 4;
            //arr[1, 1] = 5;
            //arr[1, 2] = 6;

            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.Rank);

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(arr[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //int[,,] arr = new int[1,4,5]
            //{
            //    {
            //         {1,2,3,4} ,
            //         { 4,5,6,8},
            //         { 5,6,7}
            //    }
            //};

            //int[,,] arr2 = new int[1, 2, 6];
            //arr2[0, 0, 0] = 1;
            //arr2[0, 0, 1] = 1;
            //arr2[0, 0, 2] = 1;
            //arr2[0, 0, 3] = 1;
            //arr2[0, 0, 4] = 1;
            //arr2[0, 0, 5] = 1;

            //arr2[0, 1, 0] = 2;
            //arr2[0, 1, 1] = 2;
            //arr2[0, 1, 2] = 2;
            //arr2[0, 1, 3] = 2;
            //arr2[0, 1, 4] = 2;
            //arr2[0, 1, 5] = 2;

            //Console.WriteLine(arr2.GetUpperBound(0));

            //for (int i = 0; i <= arr2.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= arr2.GetUpperBound(1); j++)
            //    {
            //        for (int k = 0; k <= arr2.GetUpperBound(2); k++)
            //        {
            //            Console.WriteLine($"{i} {j} {k} - " + arr2[i, j, k] + " ");
            //        }
            //        //Console.WriteLine();
            //    }
            //    //Console.WriteLine();
            //}


            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            ////int[,] arr2 = new int[2,];

            //int[][] arr = new int[4][];

            //arr[0] = new int[4] { 6, 6, 7, 8 };
            //arr[1] = new int[] { 1, 2, 6, 7, 9 };
            //arr[2] = new int[] { 2 };
            //arr[3] = new int[] { 9, 5, 6, 7, 8, 9, 99 };

            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.Rank);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //string t = "Azerbaijan";

            //int[] arr = { 1, 2, 3, 5, 6, 100 };

            //var arr2 = arr[4..6];

            ////Range range = 1..^3;

            //Index index = ^1;

            //Console.WriteLine(arr[index]);
            //Console.WriteLine(arr[arr.Length - 1]);
            //arr2 = arr[range];

            //foreach (var i in arr2)
            //{
            //    Console.WriteLine(i);
            //}

            #region Task 1

            //var arr = Console.ReadLine().Split(" ");

            //int[] numArr = new int[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    numArr[i] = int.Parse(arr[i]);
            //    //numArr[i] = Convert.ToInt32(arr[i]);
            //}

            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    Console.WriteLine(numArr[i]);
            //}

            //Console.WriteLine("Please add element count");
            //int count = int.Parse(Console.ReadLine());
            //int num, sum = 0;

            //int[] arr = new int[count];

            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write($"Please add {i} element");
            //    num = int.Parse(Console.ReadLine());
            //    arr[i] = num;
            //    sum += num;
            //}

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"Sum of this array`s elements is {sum}");
            #endregion

            #region Task 2

            //Random rand = new Random();
            //object t = new object();

            //int count = rand.Next(20, 50);

            //Console.WriteLine("Count - " + count);

            //int[] arr = new int[count];

            //for (int i = 0; i < count; i++)
            //{
            //    arr[i] = rand.Next(-1000, 0);
            //}

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #endregion

            #region Task 3

            //int[] arr = { 2, 3, 54, 8, 9, 1, 2, 3, 5, 6, 21, 354, 56, 1, 2, 5, 6 };

            //Console.WriteLine("Please add a number");
            //int num = int.Parse(Console.ReadLine());
            //bool isNumExist = false;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == num)
            //    {
            //        Console.WriteLine("Number is exist => " + arr[i] + " Index of this number is => " + i);
            //        isNumExist = true;
            //        break;
            //    }
            //}

            //if(!isNumExist)
            //{
            //    Console.WriteLine("Number is not exist in this array");
            //}

            ////Console.WriteLine(arr.Contains(2));
            //Console.WriteLine(Array.IndexOf(arr, num));

            #endregion

            #region Task 4

            //var arr = Console.ReadLine().Split(" ");

            //int[] numArr = new int[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    numArr[i] = int.Parse(arr[i]);
            //}


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Index => " + i + " num => " + numArr[i] + ", ");
            //}

            //Console.WriteLine();

            //int a = 0, len = numArr.Length;

            ////len - i - 1
            ////^( i + 1 )

            //for (int i = 0; i < len / 2; i++)
            //{
            //    a = numArr[i];
            //    numArr[i] = numArr[^(i + 1)];
            //    numArr[len - i - 1] = a;
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Index => " + i + " num => " + numArr[i] + ", ");
            //}


            #endregion

            #region Task 6

            //Console.WriteLine("Please enter numbers ");
            //var arr = Console.ReadLine().Split(" ");

            //int[] nums = GetMethod(arr);
            //int[] indexs = new int[nums.Length];
            //int count = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j] && i != j)
            //            count++;
            //    }
            //    indexs[i] = count + 1;
            //    count = 0;
            //}


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine($"{nums[i]} => {indexs[i]}");
            //}
            #endregion

            #region Task 7

            //Console.WriteLine("Please enter first numbers ");
            //var arr = Console.ReadLine().Split(" ");

            //int[] nums1 = GetMethod(arr);

            //Console.WriteLine("Please enter first numbers ");
            //arr = Console.ReadLine().Split(" ");

            //int[] nums2 = GetMethod(arr);
            //bool isCommon = false;
            //int count = 0;

            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    for (int j = 0; j < nums2.Length; j++)
            //    {
            //        if (nums1[i] == nums2[j] && count == 0)
            //        {
            //            Console.WriteLine("This number is common " + nums1[i]);
            //            isCommon = true;
            //            count++;
            //        }
            //    }

            //    count = 0;
            //}

            //if (!isCommon)
            //{
            //    Console.WriteLine("There is not any common number");
            //}

            #endregion


            #region task 9

            Console.WriteLine("Please enter first numbers ");
            var arr = Console.ReadLine().Split(" ");

            int[] nums1 = GetMethod(arr);

            Console.WriteLine("Please enter first numbers ");
            arr = Console.ReadLine().Split(" ");

            int[] nums2 = GetMethod(arr);

            int[] nums3 = new int[nums1.Length + nums2.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                nums3[i] = nums1[i];
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                nums3[i + nums1.Length] = nums2[i];
            }

            foreach (var item in nums3)
            {
                Console.WriteLine(item);
            }

            #endregion
        }

        public static int[] GetMethod(string[] strArr)
        {
            int[] numArr = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                numArr[i] = int.Parse(strArr[i]);
            }
            return numArr;
        }
    }
}