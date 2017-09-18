using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oddElements = OddFilter(new List<int> { 1, 2, 3, 4, 5 });

            PrintList(oddElements);
            
            Console.ReadLine();
        }
        public static List<int> OddFilter(List<int> originalList)
        {
            List<int> newList = new List<int> ();
            for (int i = 0; i < originalList.Count; i++)
            {
                if (originalList[i] % 2 != 0)
                {
                    newList.Add(originalList[i]);
                }
            }

            return newList;
        }
        private static void PrintList(List<int> list)
        {
            foreach (int element in list)
            {
                Console.Write("{0} ", element);
            }

        }
    }
}
