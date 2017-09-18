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
            TranslateToEnglish("auto");
            //RemoveWord("auto");
            foreach (KeyValuePair<string, string> words in Dictionary)
            {
                Console.WriteLine("{0}, {1}", words.Key, words.Value);
            }
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
        }
    }
}
