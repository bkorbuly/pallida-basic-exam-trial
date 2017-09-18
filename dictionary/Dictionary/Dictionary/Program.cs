using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static Dictionary<string, string> Dictionary;

        static void Main(string[] args)
        {
            Dictionary = new Dictionary<string, string>
            {
                { "alma", "apple" },
                { "fa", "tree" }
            };

            AddWord("auto", "car");
            TranslateToEnglish(Console.ReadLine());
            RemoveWord("auto");

            foreach (KeyValuePair<string, string> words in Dictionary)
            {
                Console.WriteLine("{0}, {1}", words.Key, words.Value);

            }

            TranslateToHungarian(Console.ReadLine());

            Console.ReadLine();
        }
        public static void AddWord(string hungarianWord, string englishWord)
        {
            Dictionary.Add(hungarianWord, englishWord);
        }
        public static void RemoveWord(string hungarianWord)
        {
            Dictionary.Remove(hungarianWord);
        }
        public static void TranslateToEnglish(string hungarian)
        {
            string value;
            if (Dictionary.ContainsKey(hungarian))
            {
                value = Dictionary[hungarian];
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Unknown word or It is not exist in the dictionary");
            }
        }
        public static void TranslateToHungarian(string english)
        {
            if (Dictionary.ContainsValue(english))
            {
                string mykey = Dictionary.First(x => x.Value == english).Key;
                Console.WriteLine(mykey);
            }
            else
            {
                Console.WriteLine("Unknown word or It is not exist in the dictionary");
            }

        }
    }
}
