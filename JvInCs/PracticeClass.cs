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
        public void PA_CharactersOccurancePractice_01()
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
        public void PB_CharacterOccurancePrintOnlyDuplicateCharacters_02()
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
        public void PC_CharacterOccurancePrintOnlyUniqCharacters_03()
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
        public void PD_CharacterOccuranceRemoveDuplicateCharacters_04()
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
        public void PE_WordOccurancePrint_05()
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
        public void PF_WordOccurencePrintDuplicate_06()
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
        public void PG_WordOccurancePrintUniqueWords_07()
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
        public void PH_WordOccuranceRemoveDuplicateWords_08()
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
        public void PI_NumberReverse_09()
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
        public void PJ_CheckGivenNumberIsPolindrome_10()
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
        public void PK_ChcekGivenNumberIdPrimeOrNot_11()
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
        public void PM_SumOfEachNumbers_13()
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
        public void PN_Factorial_14()
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
        public void PO_FebonacchiSeries_15()
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
        public void PP_FebonacchiSeriesFirst25_16()
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
        public void PQ_FebonacchiSeriesLessThan25_17()
        {
            int i = 0;
            int j = 1;
            Console.Write($"{i} ");
            Console.Write($"{j} ");
            int n = 25;

            //while(true)
            for (;;)
            {
                int c = i + j;
                if (c>n)
                {
                    break;
                }
                Console.Write($"{c} ");
                i = j;
                j = c;
            }
        }

        [Test]
        public void PR_NumberSwappingWithoutUsingThirdVar_18()
        {
            int a = 30;
            int b = 40;
            int c = a + b;
            a = c - a;
            b = c - a;
            Console.WriteLine($"{a}>>>>>>>>>>>>>>>{b}");
        }

        [Test]
        public void PS_StringReverseChar_19()
        {
            string s = "DAYA";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}
