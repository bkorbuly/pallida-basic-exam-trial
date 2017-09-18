using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlsFromHandles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gitHubUrls = UrlsFromHandles(new List<string> { "ghhandle1", "ghhandle2", });
            foreach(string Url in gitHubUrls)
            {
                Console.WriteLine(Url);
            }
            Console.ReadLine();
        }

        private static List<string> UrlsFromHandles(List<string> list)
        {
            string temp;
            for (int i = 0; i < list.Count; i++)
            {
                temp = list[i].ToString();
                temp = temp.Insert(0, "https://github.com/greenfox-academy/");
                list[i] = temp;
            }
            return list;            
        }
    }
}
