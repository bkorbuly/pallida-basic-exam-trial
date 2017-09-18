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
            string firstname, lastname;
            firstname = " ";
            lastname = "";
            for (int i = email.IndexOf(".") + 1; i < email.IndexOf("@"); i++)
            {
                if(i == email.IndexOf(".") + 1)
                {
                    lastname = lastname + Char.ToUpper(email[i]);
                }
                else
                {
                    lastname = lastname + email[i];
                }
               
            }

            for (int i = 0 ; i < email.IndexOf("."); i++)
            {
                if (i == 0)
                {
                    firstname = firstname + Char.ToUpper(email[i]);
                }
                else
                {
                    firstname = firstname + email[i];
                }
            }

            return lastname + firstname;
        }
    }
}
