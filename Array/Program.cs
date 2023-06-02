namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 12.05.2023
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

            #endregion

            #region 15.05.2023
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

            //Console.WriteLine("Please enter first numbers ");
            //var arr = Console.ReadLine().Split(" ");

            //int[] nums1 = GetMethod(arr);

            //Console.WriteLine("Please enter first numbers ");
            //arr = Console.ReadLine().Split(" ");

            //int[] nums2 = GetMethod(arr);

            //int[] nums3 = new int[nums1.Length + nums2.Length];

            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    nums3[i] = nums1[i];
            //}

            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    nums3[i + nums1.Length] = nums2[i];
            //}

            //foreach (var item in nums3)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region 17.05.2023

            #region Task 1 

            //int[] arr = new int[6] { 21, 43, 2, 3, 45, 6 };
            //int[] secondArr = new int[6];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    secondArr[i] = arr[i];
            //}

            //Console.WriteLine("Main Array");
            //foreach (int i in secondArr)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("Second array");
            //foreach (int i in secondArr)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Task 2 

            //int[] arr = new int[6] { 2, 43, 2, 3, 43, 6 };
            //int uniqueCount = 0;
            //bool isUnique = true;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j] && j != i)
            //        {
            //            isUnique = false;
            //            break;
            //        }
            //    }

            //    if (isUnique)
            //        Console.WriteLine("The unique elements found in the array are : " + arr[i]);

            //    uniqueCount = isUnique ? uniqueCount++ : uniqueCount + 0;
            //    isUnique = true;
            //}

            //Console.WriteLine("The unique elements count : " + uniqueCount);

            #endregion

            #region Task 4 

            //int[] arr = new int[6] { 2, 43, 9, 3, 48, 6 };
            //int oddCount = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //        oddCount++;
            //}

            //int[] oddArr = new int[oddCount];
            //int[] evenArr = new int[arr.Length - oddCount];
            //int oddIndex = 0, evenIndex = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        evenArr[evenIndex] = arr[i];
            //        evenIndex++;
            //    }
            //    else
            //    {
            //        oddArr[oddIndex] = arr[i];
            //        oddIndex++;
            //    }
            //}

            //Console.WriteLine("Even elemets array");
            //foreach (int even in evenArr)
            //{
            //    Console.Write(even + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Odd elemets array");

            //foreach (int odd in oddArr)
            //{
            //    Console.Write(odd + " ");
            //}

            #endregion

            #region Task 5 - 6

            //int[] arr = new int[6] { 2, 43, 9, 3, 48, 6 };
            //int swap = 0;

            ////ascending
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[i])
            //        {
            //            swap = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = swap;
            //        }
            //    }
            //}

            //Console.WriteLine("Ascending");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            ////descending
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] > arr[i])
            //        {
            //            swap = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = swap;
            //        }
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Descending");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region Task 7
            #endregion

            #region Task 8
            #endregion

            #region Task 9
            #endregion

            #region Task 10
            #endregion

            #region Task 11 
            #endregion

            #region Task 12 
            #endregion

            #region Task 13 
            #endregion

            #region Task 14 
            #endregion

            #region Task 15 
            #endregion

            #region Task 16 
            #endregion

            #endregion

            #region String
            //int? a;

            ////string interpolation
            //string sentence = $"Hello \"worlds!\"";

            ////string sentence2 = ;
            //char[] chars = { 'H', 'e', 'l', 'l' };

            //string test = "";

            ////Verbatim 
            //Console.WriteLine(@"Hello world");

            //string test = " ";

            //string.IsNullOrWhiteSpace(test);

            //string.IsNullOrEmpty(test);

            //if (string.IsNullOrEmpty(test))
            //{
            //    Console.WriteLine("This is not correct format");
            //}

            //string a = "Azerbaycan Respublikasi";

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i]);
            //}

            //String Formatting

            //1

            //string name = "Tofiq";
            //string surname = "Quliyev";
            //byte age = 22;

            //name = "Nicat";


            //Console.WriteLine("Name is {0}, Surname is {1}, Age is {2}, {3}", name, surname, age, null);


            //2 
            //string test3 = "asd
            //                    ";

            //Escape characters

            //string name = @"Tofiq";
            //string surname = "Quliyev";
            //byte age = 22;

            //1
            // \t - 1 tab bosluq
            //string test = $" Name is {name}\tSurname is {surname}\tAge is {age}\ttest";

            //2
            // \n - Enter
            // string test = $" Name is {name}\nSurname is {surname}\nAge is {age}\ntest";


            //3
            // \a - "bip" sound
            //string test = $" Name is {name}\a Surname is {surname}\a Age is {age}\atest";

            //4
            // \b - 
            //string test = $" Name is {name}\b Surname is {surname}\b Age is {age}\btest";

            //5
            // \v - asagi tab
            //string test = $"Name is {name}\v Surname is {surname}\v Age is {age}\v test";

            //6
            // \" \'

            // \f - ctrl + enter - yeni sehife

            //string test = $" \\b - \"Bip\" sound \n\\t - tab";

            //Console.WriteLine(test);


            //Contains
            //bool true - false
            //Console.WriteLine(test.Contains("Azər"));

            //StartWith
            //Console.WriteLine(test.StartsWith("Aerrt"));

            //EndsWith
            //Console.WriteLine(test.EndsWith("Akademiyası"));

            //CompareTo
            //Compare 
            //space - 32
            // A - 65
            // a - 97
            // B - 66


            //string test = "Azərbayc";
            //string test2 = "azərbayc";
            //int a = 0;

            //for (int i = 0; i < test.Length; i++)
            //{
            //    for (int j = 0; j < test2.Length; j++)
            //    {
            //        if (test[i] == test2[j])
            //            continue;
            //        else if (test[i] > test2[j])
            //        {
            //            a = 1;
            //            break;
            //        }
            //        else
            //        {
            //            a = -1;
            //        }

            //    }
            //}

            //Console.WriteLine(a);


            //Console.WriteLine(string.Compare("BB", "aaa"));

            //Console.WriteLine(string.Compare("ac", "aaasdfdrgsedgertg"));

            //Console.WriteLine(string.Compare("BB", "BBB"));

            //IndexOf

            //string test = "Jed Academy";

            //Console.WriteLine(test.IndexOf('a'));

            //Insert
            //string test1 = "Jed Academy";
            //Console.WriteLine(test1.Insert(3, "test1"));

            //Remove
            //string test1 = "Jed Academy";
            //Console.WriteLine(test1.Remove(3, 1));

            //Replace

            //string test = "Jed Academy A A A A A A A";
            //Console.WriteLine(test.Replace('A', 'a'));

            //Split

            //string metn = "Azerbaycan Respublikasinin Dovlet Bayragi,test,test2,test3";

            //var strArr = metn.Split(' ',',');
            //Console.WriteLine(metn);

            //foreach (var str in strArr)
            //{
            //    Console.WriteLine(str);
            //}

            //Substring

            //string metn = "Azerbaycan Respublikasinin Dovlet Bayragi,test,test2,test3";
            //Console.WriteLine(metn.Substring(10, 20));
            //Console.WriteLine(metn.Substring(10));


            //ToUpper
            //ToLower
            //string metn = "    Azərbaycan Respublikasinin Dovlet Bayragi,test,test2,test3   ";
            //string test = "...";
            //Console.WriteLine(metn.ToLower());
            // Console.WriteLine(metn.ToUpper());

            //Trim

            //TrimEnd

            //Console.Write(metn.TrimEnd());
            //Console.WriteLine(test);

            //TrimStart
            //Console.WriteLine(metn.TrimStart());


            #endregion

            #region 19.05.2023

            #region Task 1

            //byte[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //byte[] arr3 = new byte[arr1.Length];
            //arr3 = arr1;

            //byte[] arr2 = new byte[arr1.Length];
            //int iteration = 0;

            //foreach (byte element in arr1)
            //{
            //    arr2[iteration] = element;
            //    iteration++;
            //}

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr2[i] = arr1[i];
            //}

            //arr2[7] = 255;
            //arr3[0] = 100;

            //Console.WriteLine("Array 1");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write(arr1[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Array 2");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Array 3");
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.Write(arr3[i] + " ");
            //}
            #endregion

            #region Task 2

            //int[] arr = new int[] { 12, 32, 12, 34, 56, 89, 98, 34, 34 };
            //bool isUnique = true;
            //int[] uniqueArr = new int[arr.Length];
            //int countIsUnique = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (i != j && arr[i] == arr[j])
            //        {
            //            isUnique = false;
            //            break;
            //        }
            //    }

            //    if (isUnique)
            //    {
            //        uniqueArr[countIsUnique] = arr[i];
            //        countIsUnique++;
            //        //Console.WriteLine("The unique element found in the array are :" + arr[i]);
            //    }
            //    isUnique = true;
            //}

            //Console.WriteLine("The unique element found in the array are : ");
            //foreach (int i in uniqueArr)
            //{
            //    string str = i != 0 ? i + " " : "";
            //    Console.Write(str);
            //}

            #endregion

            #region Task 3

            //int[] arr = { 31, 24, 334, 4345345, 512, 61, 73, 8 };
            //int min = arr[0], max = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    //maximum
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }

            //    //minimum
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}

            //Console.WriteLine("Maximum number of array is : " + max);
            //Console.WriteLine("Minimum number of array is : " + min);

            #endregion

            #region Task 4
            #endregion

            #region Task 5
            //ascending
            //int[] arr = new int[] { 99, 20, 45, 46, 78, 13, 24, 3 };
            //int swap = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            swap = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = swap;
            //        }
            //    }
            //}

            //Console.WriteLine("Sorted array");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region Task 6

            //descending
            //int[] arr = new int[] { 99, 20, 45, 46, 78, 13, 24, 3 };
            //int swap = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] < arr[j])
            //        {
            //            swap = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = swap;
            //        }
            //    }
            //}

            //Console.WriteLine("Sorted array");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region Task 9
            //int column = 3, row = 3;
            //int[,] arr = new int[,]
            //{
            //    { 3, 4, 5 },
            //    { 2, 3, 4 },
            //    { 3, 4, 5 },
            //};

            //int[,] arr2 = new int[column, row];

            ////column 1
            //arr2[0, 0] = 1;
            //arr2[0, 1] = 2;
            //arr2[0, 2] = 3;

            ////column 2
            //arr2[1, 0] = 4;
            //arr2[1, 1] = 5;
            //arr2[1, 2] = 6;

            ////column 3
            //arr2[2, 0] = 7;
            //arr2[2, 1] = 8;
            //arr2[2, 2] = 9;

            //Console.WriteLine("Array 1");
            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("Array 2");
            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Task 11

            //int column = 3, row = 3;
            //int[,] arr = new int[,]
            //{
            //    { 3, 4, 5 },
            //    { 2, 7, 44 },
            //    { 9, 90, 55 },
            //};

            //int[,] arr2 = new int[column, row];

            ////int swap = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arr2[j, i] = arr[i, j];
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Array");
            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Task 12

            //int column = 4, row = 4;
            //int[,] arr = new int[,]
            //{
            //    { 3, 4, 5, 8 },
            //    { 2, 3, 4 , 12},
            //    { 3, 4, 5 , 21},
            //    { 13, 14, 15 , 0},
            //};

            //int sum = 0;

            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        if (i == j)
            //            sum += arr[i, j]; //sum = sum + arr[i, j]
            //    }
            //}

            //Console.WriteLine("Sum of the right diagonal of array is : " + sum);


            #endregion

            #region Task 13

            //int[,] arr = new int[,]
            //{
            //    { 3, 4, 5, 8 },
            //    { 2, 3, 4 , 12},
            //    { 3, 4, 5 , 21},
            //    { 13, 14, 15 , 0},
            //};

            //int column = 4, row = 4, length = row;

            //// length = 4
            //// 0, 3
            //// 0  = 4 - 3 - 2
            //// row = length - column - 1

            //int sum = 0;

            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        if (j == length - i - 1)
            //            sum += arr[i, j]; //sum = sum + arr[i, j]
            //    }
            //}

            //Console.WriteLine("Sum of the right diagonal of array is : " + sum);

            #endregion

            #region Task 15

            //int column = 3, row = 3;
            //int[,] arr = new int[,]
            //{
            //    { 3, 4, 5 },
            //    { 2, 3, 4 },
            //    { 3, 4, 5 },
            //};

            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        if (i < j)
            //        {
            //            arr[i, j] = 0;
            //        }
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Array");
            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Task 16
            //int column = 3, row = 3;
            //int[,] arr = new int[,]
            //{
            //    { 3, 4, 5 },
            //    { 2, 3, 4 },
            //    { 3, 4, 5 },
            //};

            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        if (i > j)
            //        {
            //            arr[i, j] = 0;
            //        }
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Array");
            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

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