using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }

        private static string NameFromEmail(string email)
        {
            char[] array = email.ToCharArray();
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            return new string(array);
        }
    }
}
