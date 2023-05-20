namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //Console.WriteLine("Input the string :");

            //string input = Console.ReadLine();

            //Console.WriteLine("The string you entered is : " + input);

            #endregion

            #region Task 4

            //string str = "Microsoft.com";
            //int len = str.Length;

            //for (int i = 0; i < len; i++)
            //{
            //    Console.Write(str[len - 1 - i] + " ");
            //}

            #endregion

            #region Task 6

            //string str1 = "This is first string";
            //string str2 = "This Is first string";
            //bool isEqual = true;

            //int len1 = str1.Length, len2 = str2.Length;
            //int len = len1 >= len2 ? len2 : len1;

            //if (len1 != len2)
            //{
            //    Console.WriteLine("This strings are not equal!");
            //}
            //else
            //{
            //    for (int i = 0; i < len; i++)
            //    {
            //        if (str1[i] != str2[i])
            //        {
            //            isEqual = false;
            //            break;
            //        }
            //    }

            //    if (isEqual)
            //    {
            //        Console.WriteLine("The length of both strings are equal and \r\nalso, both strings are equal\r\n");
            //    }
            //    else
            //    { 
            //        Console.WriteLine("The length of both strings are equal and \r\nalso, strings are not equal\r\n");
            //    }
            //}



            #endregion

            #region Task 7

            //string str = Console.ReadLine();

            //int alphabetCount = 0, digitCount = 0, characterCount = 0;

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (char.IsDigit(str[i]))
            //    {
            //        digitCount++;
            //    }
            //    else if (char.IsLetter(str[i]))
            //    {
            //        alphabetCount++;
            //    }
            //    else if (!char.IsLetterOrDigit(str[i]))
            //    {
            //        characterCount++;
            //    }

            //    if (str[i] > 47 && str[i] < 58)
            //    {
            //        digitCount++;
            //    }
            //    else if ((str[i] > 64 && str[i] < 91) || (str[i] > 96 && str[i] < 123))
            //    {
            //        alphabetCount++;
            //    }
            //    else if (!(str[i] > 47 && str[i] < 58) && !(str[i] > 64 && str[i] < 91) && !(str[i] > 96 && str[i] < 123))
            //    {
            //        characterCount++;
            //    }
            //}

            //Console.WriteLine("Number of Alphabets in the string is : " + alphabetCount);
            //Console.WriteLine("Number of Digits  in the string is : " + digitCount);
            //Console.WriteLine("Number of Special characters  in the string is : " + characterCount);

            #endregion

            #region Task 10

            //string str = Console.ReadLine();
            //int len = str.Length;
            //int[] countArr = new int[len];
            //int count = 1;

            //for (int i = 0; i < len; i++)
            //{
            //    for (int j = 0; j < len; j++)
            //    {
            //        if (i != j && str[i] == str[j])
            //        {
            //            count++;
            //        }
            //    }
            //    countArr[i] = count;
            //    count = 0;
            //}

            //int max = 0;

            //for (int i = 0; i < len; i++)
            //{
            //    if (countArr[i] > countArr[max])
            //    {
            //        max = i;
            //    }
            //}

            //Console.WriteLine("The Highest frequency of character : " + str[max]);
            //Console.WriteLine("Appears number of times : " + countArr[max]);

            //string str = Console.ReadLine();
            //int len = str.Length;
            //int count = 1, maxCount = count;
            //int maxIndex = 0;

            //for (int i = 0; i < len; i++)
            //{
            //    for (int j = 0; j < len; j++)
            //    {
            //        if (i != j && str[i] == str[j])
            //        {
            //            count++;
            //        }
            //    }

            //    if (count > maxCount)
            //    {
            //        maxIndex = i;
            //        maxCount = count;
            //    }

            //    count = 1;
            //}


            //Console.WriteLine("The Highest frequency of character : " + str[maxIndex]);
            //Console.WriteLine("Appears number of times : " + maxCount);

            #endregion

            #region Task 11

            //char[] chars = Console.ReadLine().ToCharArray();

            //char swap;

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    for (int j = i + 1; j < chars.Length; j++)
            //    {
            //        if (chars[i] < chars[j])
            //        {
            //            swap = chars[i];
            //            chars[i] = chars[j];
            //            chars[j] = swap;
            //        }
            //    }
            //}

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.Write(chars[i] + " ");
            //}

            #endregion

            #region Task 13

            //char[] chars = Console.ReadLine().ToCharArray();
            //int len = chars.Length;
            //char[] chars2 = new char[len];

            //for (int i = 0; i < len; i++)
            //{
            //    if (char.IsUpper(chars[i]))
            //    {
            //        chars2[i] = Convert.ToChar(chars[i] + 32);
            //    }
            //    else if (char.IsLower(chars[i]))
            //    {
            //        chars2[i] = Convert.ToChar(chars[i] - 32);
            //    }
            //    else
            //    {
            //        chars2[i] = chars[i];
            //    }
            //}

            //for (int i = 0; i < chars2.Length; i++)
            //{
            //    Console.Write(chars2[i]);
            //}

            #endregion

            #region Task 16

            //char character = Convert.ToChar(Console.Read());

            //if (char.IsLetter(character))
            //{
            //    if (char.IsUpper(character))
            //    {
            //        Console.WriteLine("The character is uppercase.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The character is lowercase.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The character is is not letter.");
            //}

            #endregion

            #region Task 18

            //Console.WriteLine("Please add a sentence");
            //string str = Console.ReadLine();
            //Console.WriteLine("please add word search for");
            //string strSeacrh = Console.ReadLine();
            //Console.WriteLine("Please add word for insert");
            //string insertStr = Console.ReadLine();

            //char[] chars = new char[str.Length + insertStr.Length];

            //var index = str.IndexOf(strSeacrh);

            //if (index != -1)
            //{
            //    for (int i = 0; i < chars.Length; i++)
            //    {
            //        if (index == i)
            //        {
            //            for (int j = 0; j < insertStr.Length; j++)
            //            {
            //                chars[i] = insertStr[j];
            //                if (j != insertStr.Length - 1)
            //                    i++;
            //            }
            //        }
            //        else if (index > i)
            //        {
            //            chars[i] = str[i];
            //        }
            //        else
            //        {
            //            chars[i] = str[i - insertStr.Length];
            //        }
            //    }

            //    for (int i = 0; i < chars.Length; i++)
            //    {
            //        Console.Write(chars[i]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(str);
            //}

            #endregion


            #region Task 19

            string[] fullNames = Console.ReadLine().Split(',');
            int index = 0;
            string swap = string.Empty;

            for (int i = 0; i < fullNames.Length; i++)
            {
                index = fullNames[i].Trim().IndexOf(' ');
                for (int j = index; j < fullNames[i].Length; j++)
                {
                    for (int k = index; k < fullNames[i].Length; k++)
                    {
                        if (fullNames[i][k] > fullNames[i][j])
                        {
                            swap = fullNames[i];
                            fullNames[i] = fullNames[j];
                            fullNames[j] = swap;
                        }
                    }
                }
            }


            foreach (var item in fullNames)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}