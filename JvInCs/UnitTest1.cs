using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JvInCs
{
    public class Tests
    {


        [Test]
        public void CharOccurance()
        {
            string s = "DAYANANDA";
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);
            }
            foreach (char ch in set)
            {
                int count = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (ch == s[j])
                    {
                        count++;
                    }
                }
                Console.Write(ch + ":" + count + " ");
            }
        }

        [Test]
        public void CharOccurencePrintDuplicateChar()
        {
            string s = "DAYANANDA";
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);
            }
            foreach (char ch in set)
            {
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (ch == s[i])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.Write(ch + ":" + count + " ");
                }
            }
        }

        [Test]
        public void CharOccurencePrintUniqChar()
        {
            string s = "DAYANANDA";
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);
            }
            foreach (char ch in set)
            {
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (ch == s[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.Write(ch + ":" + count + " ");
                }
            }
        }

        [Test]
        public void CharOccurenceRemoveDuplicate()
        {
            string s = "DAYANANDA";
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);
            }
            foreach (char ch in set)
            {
                Console.Write(ch);
            }
        }

        [Test]
        public void WordOcuurence()
        {
            string s = "Welcome to garden city to city";
            string[] str = s.Split(" ");
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < str.Length; i++)
            {
                set.Add(str[i]);
            }
            foreach (string str2 in set)
            {
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str2.Equals(str[i]))
                    {
                        count++;
                    }
                }
                Console.Write(str2 + ":" + count + " ");
            }
        }

        [Test]
        public void WordOcuurencePrintDuplicateWord()
        {
            string s = "Welcome to garden city to city";
            string[] str = s.Split(" ");
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < str.Length; i++)
            {
                set.Add(str[i]);
            }
            foreach (string str2 in set)
            {
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str2.Equals(str[i]))
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.Write(str2 + ":" + count + " ");
                }

            }
        }

        [Test]
        public void WordOcuurencePrintUniqueWord()
        {
            string s = "Welcome to garden city to city";
            string[] str = s.Split(" ");
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < str.Length; i++)
            {
                set.Add(str[i]);
            }
            foreach (string str2 in set)
            {
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str2.Equals(str[i]))
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.Write(str2 + ":" + count + " ");
                }

            }
        }

        [Test]
        public void WordOcuurenceRemoveDuplicateWords()
        {
            string s = "Welcome to garden city to city";
            string[] str = s.Split(" ");
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < str.Length; i++)
            {
                set.Add(str[i]);
            }
            foreach (string str2 in set)
            {
                Console.Write(str2 + " ");
            }
        }

        [Test]
        public void NumberReverseNum()
        {
            int num = 123;
            int rev = 0;
            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }
            Console.WriteLine(rev);
        }

        [Test]
        public void NumberPolindrome()
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
                Console.WriteLine("Given number " + temp + " is a polindrome");
            }
            else
            {
                Console.WriteLine("Given number " + temp + " is a not polindrome");

            }
        }

        [Test]
        public void NumberPrimeNum()
        {
            int num = 18;
            int i = 2;
            while (i < num)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Given number " + num + " is not a prime number");
                    break;
                }
                i++;
            }
            if (i == num)
            {
                Console.WriteLine("Given number " + num + " is a prime number");

            }
        }

        [Test]
        public void NumberSumOfEachNum()
        {
            int num = 123;
            int sum = 0;
            while (num > 0)
            {
                int rem = num % 10;
                sum += rem;
                num /= 10;
            }
            Console.WriteLine("Sum of each digits of given number is " + sum);
        }

        [Test]
        public void NumberFactorial()
        {
            int num = 5;
            int fact = 1;
            while (num > 1)
            {
                fact *= num;
                num--;
            }
            Console.WriteLine("Factorial of givrn number is " + fact);
        }

        [Test]
        public void NumberFebonacciSeries()
        {
            int i = 0;
            int j = 1;
            Console.Write(i + " ");
            Console.Write(j + " ");
            for (int k = 0; k < 3; k++)
            {
                int c = i + j;
                Console.Write(c + " ");
                i = j;
                j = c;
            }
        }

        [Test]
        public void NumberFebonacciSeriesFirst25()
        {
            //output==0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765 10946 17711 28657 46368 75025 121393 
            int i = 0;
            int j = 1;
            for (int k = 0; k < 25; k++)
            {
                int c = i + j;
                Console.Write(c + " ");
                i = j;
                j = c;
            }
        }

        [Test]
        public void NumberFebonacciSeriesLesserThan25()
        {
            //output ==  1 2 3 5 8 13 21 
            int i = 0;
            int j = 1;
            Console.Write(i + " ");
            Console.Write(j + " ");
            int n = 25;
            for (; ; )
            {
                int c = i + j;
                if (c > n)
                {
                    break;
                }
                Console.Write(c + " ");
                i = j;
                j = c;
            }
        }

        [Test]
        public void NumberSwapWithoutUsingThrdVar()
        {
            int a = 30;
            int b = 40;
            int c = a + b;
            a = c - a;
            b = c - a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        [Test]
        public void StringReverseChar()
        {
            string s = "DAYA";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }

        [Test]
        public void StringReverseCharUsingThirdVar()
        {
            string s = "DAYA";
            string str = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                str += s[i];
            }
            Console.WriteLine(str);
        }

        [Test]
        public void StringReverseCharWithoutUsingLengthProp()
        {
            string s = "DAYA";
            char[] ch = s.ToCharArray();
            int count = 0;
            foreach (char c in ch)
            {
                count++;
            }
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }

        [Test]
        public void StringConvrtFirstCharUppercase()
        {
            string s = "india";
            // output == India;
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
        public void StringPrintIInIndIndi()
        {
            string s = "India";
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                str += s[i];
                Console.WriteLine(str);
            }
        }

        [Test]
        public void StringSegregation()
        {
            string s = "ab@g#1$2j3";
            string ch = "";
            string num = "";
            string spl = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= 'A' && s[i] <= 'Z')
                {
                    ch += s[i];
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
            Console.WriteLine(ch + " " + num + " " + spl);
        }

        [Test]
        public void StringSegregationAddNum()
        {
            string s = "ab@g#1$2j3";
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    int n = s[i] - 48;
                    num += n;
                }
            }
            Console.WriteLine(num);
        }

        [Test]
        public void StringSwappingWithoutThrdVar()
        {
            string s1 = "java";
            string s2 = "selenium";
            s1 = s1 + s2;
            s2 = s1.Substring(0, s1.Length - s2.Length);//javaselenium
            s1 = s1.Substring(s2.Length);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }

        [Test]
        public void StringToUpperEachFirstChar()
        {

            string s = "india is my country";
            string[] str = s.Split(" ");

            for (int i = 0; i < str.Length; i++)
            {
                string s1 = str[i];
                Console.Write(s1[0].ToString().ToUpper() + str[i].Substring(1) + " ");
            }
        }

        [Test]
        public void WordReverseEachChar()
        {
            string s = "I had a dream I got everything I wanted";
            //output==  detnaw I gnihtyreve tog I maerd a dah I
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }

        [Test]
        public void WordReverseInSamePosition()
        {
            string s = "I had a dream I got everything I wanted";
            //output==  I dah a maerd I tog gnihtyreve I detnaw 
            string[] str = s.Split(" ");
            for (int i = 0; i < str.Length; i++)
            {
                string str2 = str[i];
                for (int j = str2.Length - 1; j >= 0; j--)
                {
                    Console.Write(str2[j]);
                }
                Console.Write(" ");
            }
        }

        [Test]
        public void WordReverse()
        {
            string s = "I had a dream I got everything I wanted";
            //output == wanted I everything got I dream a had I
            string[] str = s.Split(" ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i] + " ");
            }
        }

        [Test]
        public void WordReverseInterchangeFirstNLastIndex()
        {
            string s = "I had a dream I got everything I wanted";
            //output == wanted had a dream I got everything I I 
            string[] str = s.Split(" ");
            string temp = str[0];
            str[0] = str[str.Length - 1];
            str[str.Length - 1] = temp;
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
        }

        [Test]
        public void ArrayAscending()
        {
            int[] arr = { 30, 5, 70, 22, 35 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        [Test]
        public void ArrayDescending()
        {
            int[] arr = { 30, 5, 70, 22, 35 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        [Test]
        public void ArrayPrintFirstTwoMaxNum()
        {
            int[] arr = { 30, 5, 70, 22, 35 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(arr[0] + " " + arr[1]);
        }

        [Test]
        public void ArrayPrintFirstTwoMinNum()
        {
            int[] arr = { 30, 5, 70, 22, 35 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(arr[0] + " " + arr[1]);
        }

        [Test]
        public void ArrayAdditionFirstThreeMaxNum()
        {
            int[] arr = { 30, 5, 70, 20, 40 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of first 3 maximum elements is : " + sum);
        }

        [Test]
        public void ArrayAdditionLastThreeMaxNum()
        {
            int[] arr = { 30, 5, 70, 20, 40 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            int sum = 0;
            for (int i = arr.Length - 3; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of last 3 maximum elements is : " + sum);
        }

        [Test]
        public void ArrayAdditionFirstThreeMinNum()
        {
            int[] arr = { 30, 5, 70, 20, 40 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of first 3 minimum elements is : " + sum);
        }

        [Test]
        public void ArrayAdditionLastThreeMinNum()
        {
            int[] arr = { 30, 5, 70, 20, 40 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            int sum = 0;
            for (int i = arr.Length - 3; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of last 3 minimum elements is : " + sum);
        }

        [Test]
        public void ArrayPrintDuplicateArrElements()
        {
            int[] a = { 4, 8, 8, 9, 10, 77, 8, 11, 77 };
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                set.Add(a[i]);
            }
            foreach (int ir in set)
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (ir == a[i])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.Write(ir + " ");
                }
            }
        }

        [Test]
        public void ArraySeparationOfSameNumber()
        {
            int[] a = { 2, 4, 0, 0, 8, 0, 5, 0 };
            int[] b = new int[a.Length];
            int n = a.Length - 1;
            int m = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    b[n] = a[i];
                    n--;
                }
                else
                {
                    b[m] = a[i];
                    m++;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
        }

        [Test]
        public void ArrayAddition()
        {
            int[] a = { 2, 4, 6, 8 };
            int[] b = { 2, 4, 6 };
            int length = a.Length;
            if (a.Length < b.Length)
            {
                length = b.Length;
            }
            for (int i = 0; i < length; i++)
            {
                try
                {
                    Console.Write(a[i] + b[i] + " ");
                }
                catch (Exception)
                {
                    if (a.Length > b.Length)
                    {
                        Console.Write(a[i]);
                    }
                    else
                    {
                        Console.Write(b[i]);
                    }
                }
            }
        }

        [Test]
        public void ArrayKeyProgram()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int key = 1;
            for (int i = 0; i < key; i++)
            {
                int temp = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    arr[j - 1] = arr[j];
                }
                arr[arr.Length - 1] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        [Test]
        public void StringArrayFindMaxElement()
        {
            string[] str = { "abc", "Hi", "mango", "j", "tyss", "abcde" };
            string s = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (s.Length < str[i].Length)
                {
                    s = str[i];
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (s.Length == str[i].Length)
                {
                    Console.Write(str[i] + " ");
                }
            }
        }

        [Test]
        public void StringArrayFindMinElement()
        {
            string[] str = { "abc", "Hi", "mango", "j", "tyss", "abcde" };
            string s = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (s.Length > str[i].Length)
                {
                    s = str[i];
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (s.Length == str[i].Length)
                {
                    Console.Write(str[i] + " ");
                }
            }
        }
    }
}


