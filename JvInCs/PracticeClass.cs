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
        public void P1_CharactersOccurancePractice()
        {
            string name = "DAYANANDA M N";
            HashSet<char> nameCharacters = new HashSet<char>();
            for (int i = 0; i < name.Length; i++)
            {
                nameCharacters.Add(name[i]);
            }

            foreach(char ch in nameCharacters)
            {
                int count = 0;
                for(int j = 0; j < name.Length; j++)
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
        public void P2_CharacterOccurancePrintOnlyDuplicateCharacters()
        {
            string name = "DAYANANDA";
            HashSet<char> charName = new HashSet<char>();
            for (int i = 0; i < name.Length; i++)
            {
                charName.Add(name[i]);
            }

            foreach(char ch in charName)
            {
                int count = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    if (ch == name[j])
                    {
                        count++;
                    }
                }
                if (count>1)
                {
                    Console.WriteLine($"Character {ch} is duplicated {count} times");
                }
            }
        }
    }
}
