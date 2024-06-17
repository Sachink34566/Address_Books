using Address_Books;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Address_Books
{
    public class DeleteDetails
    {

        public static void Deletecontact(List<Contacts> list)
        {

            Console.WriteLine("Deletingthe contect details");
            Console.WriteLine("Enter first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("enter last name");
            string lastname = Console.ReadLine();

            if (firstname.Length == 0 || lastname.Length == 0)
            {
                Console.WriteLine("Please enter correct input");
                return;
            }
            else if (firstname.Length > 0 && lastname.Length > 0)
            {

                foreach (Contacts item in list)
                {
                    if (item.Firstname == firstname && item.Lastname == lastname)
                    {
                        list.Remove(item);
                        Console.WriteLine("Successfully deleted !");
                        return;
                    }

                }


            }

        }
    }
}