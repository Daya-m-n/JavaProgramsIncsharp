using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JvInCs
{
    public class PracticeClass
    {
        [Test]
        public void PA_01_CharactersOccurancePractice()
        {
            string name = "DAYANANDA M N";
            HashSet<char> nameCharacters = new HashSet<char>();
            for (int i = 0; i < name.Length; i++)
            {
                nameCharacters.Add(name[i]);
            }

            foreach (char ch in nameCharacters)
            {
                int count = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    if (ch == name[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Character {ch} is present in {name} {count}  times");
            }
        }



        [Test]
        public void PB_02_CharacterOccurancePrintOnlyDuplicateCharacters()
        {
            string name = "DAYANANDA";
            HashSet<char> charName = new HashSet<char>();
            for (int i = 0; i < name.Length; i++)
            {
                charName.Add(name[i]);
            }

            foreach (char ch in charName)
            {
                int count = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    if (ch == name[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine($"Character {ch} is duplicated {count} times");
                }
            }
        }

        [Test]
        public void PC_03_CharacterOccurancePrintOnlyUniqCharacters()
        {
            string name = "DAYANANDA";
            HashSet<char> nameInChar = new HashSet<char>();

            for (int i = 0; i < name.Length; i++)
            {
                nameInChar.Add(name[i]);
            }

            foreach (char ch in nameInChar)
            {
                int count = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    if (ch == name[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine($"Character {ch} is unique");
                }
            }
        }

        [Test]
        public void PD_04_CharacterOccuranceRemoveDuplicateCharacters()
        {
            string name = "DAYANANDA";
            HashSet<char> nameInChar = new HashSet<char>();
            for (int i = 0; i < name.Length; i++)
            {
                nameInChar.Add(name[i]);
            }
            foreach (char ch in nameInChar)
            {
                Console.WriteLine($"After removing duplicates from {name} becomes >> {ch}");
            }
        }

        [Test]
        public void PE_05_WordOccurancePrint()
        {
            string s = "Welcome to garden city to city";
            string[] words = s.Split(' ');
            HashSet<string> hashsetString = new HashSet<string>();

            for (int i = 0; i < words.Length; i++)
            {
                hashsetString.Add(words[i]);
            }

            foreach (string word in hashsetString)
            {
                int count = 0;
                for (int j = 0; j < words.Length; j++)
                {
                    if (word.Equals(words[j]))
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{word} : {count}");
            }
        }

        [Test]
        public void PF_06_WordOccurencePrintDuplicate()
        {
            string s = "Welcome to garden city to city";
            string[] splittedWords = s.Split(" ");
            HashSet<string> uniqueWordSet = new HashSet<string>();

            for (int i = 0; i < splittedWords.Length; i++)
            {
                uniqueWordSet.Add(splittedWords[i]);
            }

            foreach (string str in uniqueWordSet)
            {
                int count = 0;
                for (int j = 0; j < splittedWords.Length; j++)
                {
                    if (str.Equals(splittedWords[j]))
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine($"{str} present {count} times");
                }
            }
        }

        [Test]
        public void PG_07_WordOccurancePrintUniqueWords()
        {
            string s = "Welcome to garden city to city";
            string[] splittedWords = s.Split(" ");
            HashSet<string> hashSet = new HashSet<string>();

            for (int i = 0; i < splittedWords.Length; i++)
            {
                hashSet.Add(splittedWords[i]);
            }

            foreach (string word in hashSet)
            {
                int count = 0;
                for (int j = 0; j < splittedWords.Length; j++)
                {
                    if (word.Equals(splittedWords[j]))
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine($"{word} : {count}");
                }
            }
        }

        [Test]
        public void PH_08_WordOccuranceRemoveDuplicateWords()
        {
            string s = "Welcome to garden city to city";
            string[] splittedWords = s.Split(" ");
            HashSet<string> hashSet = new HashSet<string>();

            for (int i = 0; i < splittedWords.Length; i++)
            {
                hashSet.Add(splittedWords[i]);
            }
            foreach (string word in hashSet)
            {
                Console.Write($"{word} ");
            }
        }

        [Test]
        public void PI_09_NumberReverse()
        {
            int num = 123;
            int rev = 0;

            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }
            Console.WriteLine($"Reverse of {num} is : {rev}");
        }

        [Test]
        public void PJ_10_CheckGivenNumberIsPolindrome()
        {
            int num = 123321;
            int temp = num;
            int rev = 0;

            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }

            if (temp == rev)
            {
                Console.WriteLine($"The given number : {temp} is a polindrome number");
            }
            else
            {
                Console.WriteLine($"The given number : {temp} is not a polindrome number");
            }
        }

        [Test]
        public void PK_11_ChcekGivenNumberIdPrimeOrNot()
        {
            int num = 13;
            int i = 2;

            //while(i<Math.Sqrt(num))
            while (i < num)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Given number is not a prime number");
                    break;
                }
                i++;
            }
            if (i == num)
            {
                Console.WriteLine("given number is a prime number");
            }
        }

        //[Test]
        //public void PL_CheckGivenNumberIsAPrimeNumber2_12()
        //{
        //    Console.Write("Enter a number: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    bool isPrime = true;

        //    if (number <= 1)
        //    {
        //        isPrime = false;
        //    }
        //    else
        //    {
        //        for (int i = 2; i <= Math.Sqrt(number); i++)
        //        {
        //            Console.WriteLine($"Checking: {number} % {i}");

        //            if (number % i == 0)
        //            {
        //                Console.WriteLine($"Divisible by {i} → Not Prime");
        //                isPrime = false;
        //                break;
        //            }
        //        }
        //    }

        //    if (isPrime)
        //        Console.WriteLine($"{number} is Prime");
        //    else
        //        Console.WriteLine($"{number} is NOT Prime");
        //}

        [Test]
        public void PM_13_SumOfEachNumbers()
        {
            int num = 1234;
            int sum = 0;

            while (num > 0)
            {
                int rem = num % 10;
                sum += rem;
                num /= 10;
            }

            Console.WriteLine($"Sum of each numbers is : {sum}");
        }

        [Test]
        public void PN_14_Factorial()
        {
            //5*4*3*2*1
            int num = 5;
            int fact = 1;

            while (num > 1)
            {
                fact *= num;
                num--;
            }
            Console.WriteLine($"factorial of given number is : {fact}");
        }

        [Test]
        public void PO_15_FebonacchiSeries()
        {
            int i = 0;
            int j = 1;
            Console.Write($"{i} ");
            Console.Write($"{j} ");
            for (int k = 0; k < 3; k++)
            {
                int sum = i + j;
                Console.Write($"{sum} ");
                i = j;
                j = sum;
            }
        }

        [Test]
        public void PP_16_FebonacchiSeriesFirst25()
        {
            int i = 0;
            int j = 1;
            Console.Write($"{i} ");
            Console.Write($"{j} ");
            for (int k = 0; k < 25; k++)
            {
                int count = i + j;
                Console.Write($"{count} ");
                i = j;
                j = count;
            }
        }

        [Test]
        public void PQ_17_FebonacchiSeriesLessThan25()
        {
            int i = 0;
            int j = 1;
            Console.Write($"{i} ");
            Console.Write($"{j} ");
            int n = 25;

            //while(true)
            for (; ; )
            {
                int c = i + j;
                if (c > n)
                {
                    break;
                }
                Console.Write($"{c} ");
                i = j;
                j = c;
            }
        }

        [Test]
        public void PR_18_NumberSwappingWithoutUsingThirdVar()
        {
            int a = 30;
            int b = 40;
            int c = a + b;
            a = c - a;
            b = c - a;
            Console.WriteLine($"{a}>>>>>>>>>>>>>>>{b}");
        }

        [Test]
        public void PS_19_StringReverseChar()
        {
            string s = "DAYA";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }

        [Test]
        public void PT_20_StringReverseCharUsingThirdVar()
        {
            string s = "DAYA";
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i];
            }
            Console.WriteLine($"Reversed string is {reverse}");
        }

        [Test]
        public void PU_21_StringReverseCharWithoutUsingLengthProp()
        {
            string s = "DAYA";
            char[] ch = s.ToCharArray();
            int count = 0;
            foreach (char chr in ch)
            {
                count++;
            }
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }

        [Test]
        public void PV_22_StringConvrtFirstCharUppercase()
        {
            string s = "india";//Output>>>>India
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(s[i].ToString().ToUpper());
                }
                else
                {
                    Console.Write(s[i]);
                }
            }
        }

        [Test]
        public void PW_23_StringPrintIInIndIndi()
        {
            string s = "India";
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                str += s[i];
                Console.Write(str);
            }
        }

        [Test]
        public void PX_24_StringSegregation()
        {
            string s = "ab@g#1$2j3";
            string chr = "";
            string num = "";
            string spl = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= 'A' && s[i] <= 'Z')
                {
                    chr += s[i];
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    num += s[i];
                }
                else
                {
                    spl += s[i];
                }
            }
            Console.WriteLine($"Chracters: {chr}   Numbers: {num}   SpecilCharacter: {spl}");
        }

        [Test]
        public void PY_25_SegregateNumbersFromStringAndAddThem()
        {
            string s = "1@6878($#56%^9";
            int add = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    add += s[i] - '0';
                }
            }
            Console.WriteLine($"Sum of the digits present in the given string is : {add}");
        }

        [Test]
        public void PZ_26_StringSwappingWithoutThrdVar()
        {
            string s1 = "java";
            string s2 = "selenium";
            s1 = s1 + s2;
            s2 = s1.Substring(0, s1.Length - s2.Length);
            s1 = s1.Substring(s2.Length);
            Console.WriteLine($"s1:{s1}  s2:{s2}");
        }

        [Test]
        public void PZA_27_StringToUpperEachFirstChar()
        {
            string s = "india is my country";
            string[] word = s.Split(" ");
            for (int i = 0; i < word.Length; i++)
            {
                string str = word[i];
                Console.Write($"{str[0].ToString().ToUpper()}{word[i].Substring(1)} ");
            }
        }

        [Test]
        public void PZB_28_WordReverseEachChar()
        {
            string s = "I had a dream I got everything I wanted";
            //output==  detnaw I gnihtyreve tog I maerd a dah I
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write($"{s[i]}");
            }
        }

        [Test]
        public void PZC_29_WordReverseInSamePosition()
        {
            string s = "I had a dream I got everything I wanted";
            //output==  I dah a maerd I tog gnihtyreve I detnaw 
            string[] word = s.Split(" ");
            for (int i = 0; i < word.Length; i++)
            {
                string str = word[i];
                for (int j = str.Length - 1; j >= 0; j--)
                {
                    Console.Write($"{str[j]}");
                }
                Console.Write(" ");
            }
        }

        [Test]
        public void PZD_30_WordReverse()
        {
            string s = "I had a dream I got everything I wanted";
            //output == wanted I everything got I dream a had I
            string[] word = s.Split(" ");
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write($"{word[i]} ");
            }
        }

        [Test]
        public void PZE_31_WordReverseInterchangeFirstNLastIndex()
        {
            string s = "I had a dream I got everything I wanted";
            //output == wanted had a dream I got everything I I 
            string[] word = s.Split(" ");
            string temp = word[0];
            word[0] = word[word.Length - 1];
            word[word.Length - 1] = temp;
            foreach (string item in word)
            {
                Console.Write($"{item} ");
            }
        }

        [Test]
        public void PZF_32_ArrayAcsending()
        {
            int[] unSortedArray = { 23, 21, 45, 4, 56, 8 };
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                for (int j = i + 1; j < unSortedArray.Length; j++)
                {
                    if (unSortedArray[i] > unSortedArray[j])
                    {
                        int temp = unSortedArray[i];
                        unSortedArray[i] = unSortedArray[j];
                        unSortedArray[j] = temp;
                    }
                }
            }
            foreach (int i in unSortedArray)
            {
                Console.Write(i + " ");
            }
        }

        [Test]
        public void PZG_33_ArrayDesending()
        {
            int[] unSortedArray = { 23, 21, 45, 4, 56, 8 };
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                for (int j = i + 1; j < unSortedArray.Length; j++)
                {
                    if (unSortedArray[i] < unSortedArray[j])
                    {
                        int temp = unSortedArray[i];
                        unSortedArray[i] = unSortedArray[j];
                        unSortedArray[j] = temp;
                    }
                }
            }
            foreach (int i in unSortedArray)
            {
                Console.Write($"{i} ");
            }
        }

        [Test]
        public void PZH_34_ArrayPrintFirstTwoMaxNum()
        {
            int[] unSortedArray = { 23, 21, 45, 4, 56, 8 };
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                for (int j = i + 1; j < unSortedArray.Length; j++)
                {
                    if (unSortedArray[i] < unSortedArray[j])
                    {
                        int temp = unSortedArray[i];
                        unSortedArray[i] = unSortedArray[j];
                        unSortedArray[j] = temp;
                    }
                }
            }
            Console.Write($"{unSortedArray[0]} {unSortedArray[1]}");
        }

        [Test]
        public void PZI_35_ArrayPrintFirstTwoMinNum()
        {
            int[] unSortedArray = { 23, 21, 45, 4, 56, 8 };
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                for (int j = i + 1; j < unSortedArray.Length; j++)
                {
                    if (unSortedArray[i] > unSortedArray[j])
                    {
                        int temp = unSortedArray[i];
                        unSortedArray[i] = unSortedArray[j];
                        unSortedArray[j] = temp;
                    }
                }
            }
            Console.Write($"{unSortedArray[0]} {unSortedArray[1]}");
        }

        [Test]
        public void PZJ_36_ArrayAdditionFirstThreeMaxNum()
        {
            int[] unSortedArray = { 23, 21, 40, 4, 50, 110, 8 };
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                for (int j = i + 1; j < unSortedArray.Length; j++)
                {
                    if (unSortedArray[i] < unSortedArray[j])
                    {
                        int temp = unSortedArray[i];
                        unSortedArray[i] = unSortedArray[j];
                        unSortedArray[j] = temp;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += unSortedArray[i];
            }
            Console.WriteLine($"Sum of first three max numbers is {sum}");
        }

        [Test]
        public void PZK_37_ArrayAdditionLastThreeMaxNum()
        {
            int[] unSortedArray = { 23, 21, 40, 4, 50, 100, 8 };
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                for (int j = i + 1; j < unSortedArray.Length; j++)
                {
                    if (unSortedArray[i] > unSortedArray[j])
                    {
                        int temp = unSortedArray[i];
                        unSortedArray[i] = unSortedArray[j];
                        unSortedArray[j] = temp;
                    }
                }
            }
            int sum = 0;
            for (int i = unSortedArray.Length - 3; i < unSortedArray.Length; i++)
            {
                sum += unSortedArray[i];
            }
            Console.WriteLine($"Addition of last 3 maximum values is : {sum}");
        }

        [Test]
        public void PZL_38_ArrayAdditionFirstThreeMinNum()
        {
            int[] unSortedArray = { 23, 21, 40, 4, 13, 100, 8 };
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                for (int j = i + 1; j < unSortedArray.Length; j++)
                {
                    if (unSortedArray[i] > unSortedArray[j])
                    {
                        int temp = unSortedArray[i];
                        unSortedArray[i] = unSortedArray[j];
                        unSortedArray[j] = temp;
                    }
                }
            }

            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += unSortedArray[i];
            }
            Console.WriteLine($"Addition of first three minimum numbers is : {sum}");
        }

        [Test]
        public void PZM_39_ArrayAdditionLastThreeMinNum()
        {
            int[] unSortedArray = { 23, 21, 40, 10, 13, 100, 7 };
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                for (int j = i+1; j < unSortedArray.Length; j++)
                {
                    if (unSortedArray[i] < unSortedArray[j])
                    {
                        int temp = unSortedArray[i];
                        unSortedArray[i] = unSortedArray[j];
                        unSortedArray[j] = temp;
                    }
                }
            }
            int sum = 0;
            for (int i = unSortedArray.Length-3; i < unSortedArray.Length; i++)
            {
                sum += unSortedArray[i];
            }
            Console.WriteLine($"Addition of last 3 minimum number is : {sum}");
        }

        [Test]
        public void PZN_40_ArrayPrintDuplicateArrElements()
        {
            int[] arr = { 3, 6, 9, 5, 3, 55, 99, 77, 55, 6, 3 ,10,10};
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                set.Add(arr[i]);
            }
            foreach(int i in set)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j]==i)
                    {
                        count++;
                    }
                }
                if (count>1)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        [Test]
        public void PZO_41_ArraySeparationOfSameNumber()
        {
            //output >>>> 1, 3, 4, 0, 66, 6, 7, 2, 2, 2, 2, 
            int[] arr = { 1, 2, 3, 4, 0, 2, 66, 2, 6, 7, 2 };
            int[] arr1 = new int[arr.Length];
            int m = 0;
            int n = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==2)
                {
                    arr1[n] = arr[i];
                    n--;
                }
                else
                {
                    arr1[m] = arr[i];
                    m++;
                }
            }
            foreach(int i in arr1)
            {
                Console.Write($"{i}, ");
            }
        }

        [Test]
        public void PZP_42_ArrayAddition()
        {
            int[] a = { 2, 4, 6, 8, 9 };
            int[] b = { 4, 6, 8, 10 };
            int length = a.Length;
            if (length<b.Length)
            {
                length = b.Length;
            }
            for (int i = 0; i < length; i++)
            {
                try
                {
                    Console.Write($"{a[i]+b[i]} ");
                }
                catch (Exception)
                {
                    if (a.Length>b.Length)
                    {
                        Console.Write($"{a[i]} ");
                    }
                    else
                    {
                        Console.Write($"{b[i]} ");
                    }
                }
            }
        }

        [Test]
        public void PZQ_43_ArrayKeyProgramLeftRotation()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int key = 2;
            for (int i = 0; i < key; i++)
            {
                int temp = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    arr[j - 1] = arr[j];
                }
                arr[arr.Length - 1] = temp;
            }
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }
        }

        [Test]
        public void PZR_44_StringArrayFindMaxCharWord()
        {
            string[] str = { "abc", "Hi", "mango", "j", "tyss", "abcde" };
            string temp = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (temp.Length < str[i].Length)
                {
                    temp = str[i];
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (temp.Length==str[i].Length)
                {
                    Console.Write($"{str[i]} ");
                }
            }
        }

        [Test]
        public void PZS_45_StringArrayFindMinCharWord()
        {
            string[] str = { "abc", "Hi", "mango", "ji", "tyss", "abcde" };
            string temp = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (temp.Length > str[i].Length)
                {
                    temp = str[i];
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (temp.Length == str[i].Length)
                {
                    Console.Write($"{str[i]} ");
                }
            }
        }
    }
}
